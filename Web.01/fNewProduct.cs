﻿using QLBH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class fNewProduct : Form
    {
        private Product product;

        public fNewProduct()
        {
            InitializeComponent();
        }


        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fNewProduct_Load(object sender, EventArgs e)
        {
            mQuantity.ValidatingType = typeof(UInt64);
            mPrice.ValidatingType = typeof(decimal);
            mMarketPrice.ValidatingType = typeof(decimal);
            using (var db = new EFDbContext())
            {
                cbCategories.DisplayMember = "Name";
                cbCategories.ValueMember = "CategoryID";
                cbCategories.DataSource = db.Categories.OrderBy(c =>
               c.Order).Select(c => new { c.CategoryID, c.Name }).ToList();
                cbCategories.Text = null; //không hiển thị dữ liệu, nếu bỏ lệnh này, sẽ hiển thị theo loại đầu tiên
                //hoặc cbCategories.SelectedValue = "";//không thể đặt null;
            }

        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            //Thuộc tính Filter xác định loại tệp
            openFileDialog1.Filter =
                "All file|*.*|" +
                "Bitmap File | *.bmp; *.dib |" +
                " JPEG | *.jpg; *.jpe; *.jpeg; *.jfif |" +
                " GIF | *.gif |" +
                " TIFF | *.tif; *.tiff |" +
                " PNG | *.png | " +
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
                product = new Product(); //Tạo một đối tượng cho sản phẩm mới
                product.Name = txtName.Text;
                product.Quantity = Convert.ToInt32(mQuantity.Text);
                product.Price = Convert.ToDecimal(mPrice.Text);
                product.MarketPrice =
               string.IsNullOrWhiteSpace(mMarketPrice.Text) ? (decimal?)null :
               Convert.ToDecimal(mMarketPrice.Text);
                product.Description = rDescription.Text;
                product.Status = ckStatus.Checked;
                product.CategoryID = Convert.ToInt32(cbCategories.SelectedValue);
                using (var db = new EFDbContext())
                {
                    db.Products.Add(product); //Thêm sản phẩm vào bối cảnh
                    db.SaveChanges(); //Lưu các thay đổi vào csdl
                                      //Lưu hình vào thư mục hình
                    if (!string.IsNullOrWhiteSpace(txtImageFile.Text))
                    {
                        string ext =
                       txtImageFile.Text.Substring(txtImageFile.Text.LastIndexOf("."),
                       txtImageFile.Text.Length - txtImageFile.Text.LastIndexOf("."));
                        product.ImageFile = product.ProductID + ext;
                        pictureBox1.Image.Save(Utility.ImagePath + product.ProductID + ext);
                        db.SaveChanges(); //Lưu các thay đổi vào csdl
                    }
                }
                //Xóa trống và thiết lập lại các điều khiển
                txtName.Text = null;
                //cbCategories.Text = null;
                mQuantity.Text = null;
                mPrice.Text = null;
                mMarketPrice.Text = null;
                rDescription.Text = null;
                ckStatus.Checked = true;
                txtImageFile.Text = null;
                pictureBox1.ImageLocation = null;
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0,
               1000);
            }
            txtName.Focus();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sản phẩm?", txtName, 0, 0, 1000);
                e.Cancel = true; //Phải nhập dữ liệu cho cột not null
            }
            else if (txtName.Text.Length > 200)
            {
                toolTip1.Show("Tên sản phẩm - tối đa 200 ký tự?", txtName, 0, 0,
               1000);
                e.Cancel = true;
            }
        }

        private void rDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rDescription.Text))
            {
                toolTip1.Show("Hãy nhập mô tả sản phẩm?", rDescription, 0, 0, 1000);
                e.Cancel = true; // Phải nhập dữ liệu cho cột not null
            }
            else if (rDescription.Text.Length > 500)
            {
                toolTip1.Show("Mô tả sản phẩm - tối đa 500 ký tự?", rDescription, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtImageFile_Validating(object sender, CancelEventArgs e)
        {
            pictureBox1.ImageLocation = null;
            if (string.IsNullOrWhiteSpace(txtImageFile.Text))
                return; //Không cần nhập dữ liệu cho cột có thể null
            if (txtImageFile.Text.Length > 200)
            {
                toolTip1.Show("Tên tập tin - tối đa 200 ký tự?", txtImageFile, 0, 0,
               1000);
                e.Cancel = true;
            }
            else if (!File.Exists(txtImageFile.Text))
            {
                toolTip1.Show("Tên tập tin sai hoặc Tập tin không tồn tại?",
               txtImageFile, 0, 0, 1000);
                e.Cancel = true;
            }
            else
                pictureBox1.ImageLocation = txtImageFile.Text;
        }

        private void cbCategories_Validating(object sender, CancelEventArgs e)
        {
            if (cbCategories.FindStringExact(cbCategories.Text) < 0) //Nếu sai tên loại
            {
                toolTip1.Show("Nhập sai loại sản phẩm?", cbCategories, 0, 0, 1000);
                e.Cancel = true;

            }
        }

        private void mQuantity_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput) //Nếu nhập sai kiểu
            {
                toolTip1.Show("Dữ liệu sai kiểu số nguyên?", mQuantity, 0, 0, 1000);
                e.Cancel = true;
            }
            else if ((UInt64)e.ReturnValue < 0) //Nếu giá trị âm
            {
                toolTip1.Show("Số lượng phải >= 0?", mQuantity, 0, 0, 1000);
                e.Cancel = true;
            }

        }

        private void mPrice_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu số thực?", mPrice, 0, 0, 1000);
                e.Cancel = true;
            }
            else if ((decimal)e.ReturnValue < 0)
            {
                toolTip1.Show("Giá phải >= 0?", mPrice, 0, 0, 1000);
                e.Cancel = true;
            }

        }

        private void mMarketPrice_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mMarketPrice_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mMarketPrice.Text))
                return; //Không cần nhập dữ liệu cho cột có thể null
            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu số thực?", mMarketPrice, 0, 0, 1000);
                e.Cancel = true;
            }
            else if ((decimal)e.ReturnValue < 0)
            {
                toolTip1.Show("Giá phải >= 0?", mMarketPrice, 0, 0, 1000);
                e.Cancel = true;
            }
        }
    }
}
        

