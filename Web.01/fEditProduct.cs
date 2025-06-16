using Microsoft.EntityFrameworkCore;
using QLBH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class fEditProduct : Form
    {
        private Product product;
        private long ProductID;
        private EFDbContext db = new EFDbContext();
        public fEditProduct(long ProductID)
        {
            InitializeComponent();
            this.ProductID = ProductID;
        }

        private void fEditProduct_Load(object sender, EventArgs e)
        {
            product = db.Products.Include(p => p.Category).Single(p => p.ProductID == ProductID);
            //Nếu bỏ Include(), bạn chỉ có thể truy cập product.CategoryID, nhưng không thể lấy thông tin product.Category.Name.
            Text = "SỬA ĐỔI SẢN PHẨM " + product.ProductID.ToString();
            txtName.Text = product.Name;
            mQuantity.Text = product.Quantity.ToString();
            mPrice.Text = product.Price.ToString();
            mMarketPrice.Text = product.MarketPrice.ToString();
            ckStatus.Checked = product.Status;
            rDescription.Text = product.Description;
            txtImageFile.Text =
                    string.IsNullOrWhiteSpace(product.ImageFile) ? null : Utility.ImagePath+ product.ImageFile;
            pictureBox1.ImageLocation = txtImageFile.Text;
            //Nạp dữ liệu cho ComboBox
            cbCategories.DisplayMember = "Name";
            cbCategories.ValueMember = "CategoryID";
            cbCategories.DataSource = db.Categories.Select(c => new
            {
                c.CategoryID,
                c.Name
            }).ToList();
            cbCategories.Text = product.Category.Name;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            //Nhớ xóa trống thuộc tính Filename lúc thiết kế
            //Filter có thể thiết lập lúc thiết kế
            openFileDialog1.Filter = "All file|*.*|" +
                "Bitmap File | *.bmp; *.dib | " +
                "JPEG | *.jpg; *.jpe; *.jpeg; *.jfif | " +
                "GIF | *.gif | " +
                "TIFF | *.tif; *.tiff | " +
                "PNG | *.png | " +
                "ICO | *.ico";
             if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImageFile.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sản phẩm?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbCategories.Text))
            {
                toolTip1.Show("Hãy nhập loại sản phẩm?", cbCategories, 0, 0, 1000);
                cbCategories.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mQuantity.Text))
            {
                toolTip1.Show("Hãy nhập số lượng?", mQuantity, 0, 0, 1000);
                mQuantity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mPrice.Text))
            {
                toolTip1.Show("Hãy nhập giá bán?", mPrice, 0, 0, 1000);
                mPrice.Focus();
                return;
            }

            try
            {
                product.Name = txtName.Text;
                product.Quantity = Convert.ToInt32(mQuantity.Text);
                product.Price = Convert.ToDecimal(mPrice.Text);
                product.MarketPrice =
               string.IsNullOrWhiteSpace(mMarketPrice.Text) ? (decimal?)null :
               Convert.ToDecimal(mMarketPrice.Text);
                product.Description = rDescription.Text;
                product.Status = ckStatus.Checked;
                product.CategoryID =
               Convert.ToInt32(cbCategories.SelectedValue);
                //Xóa tập tin hình cũ
                if (!string.IsNullOrWhiteSpace(product.ImageFile) && product.ImageFile != txtImageFile.Text)
 {
                    File.Delete(Utility.ImagePath + product.ImageFile);
                    product.ImageFile = null;
                }
                //Lưu tập tin hình mới
                if (!string.IsNullOrWhiteSpace(txtImageFile.Text) &&
               product.ImageFile != txtImageFile.Text)
                {
                    string ext =
                   txtImageFile.Text.Substring(txtImageFile.Text.LastIndexOf("."),
                   txtImageFile.Text.Length - txtImageFile.Text.LastIndexOf("."));
                    product.ImageFile = product.ProductID + ext;
                    pictureBox1.Image.Save(Utility.ImagePath +
                   product.ProductID + ext);
                }
                db.SaveChanges();
                toolTip1.Show("Đã lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0,
               0, 1000);
            }
            txtName.Focus();
        }

    }
}
