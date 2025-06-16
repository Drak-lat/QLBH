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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBH
{
    public partial class fManageProduct : Form
    {
        private int CategoryID;
        public fManageProduct()
        {
            InitializeComponent();
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                CategoryID = Convert.ToInt32(cbCategories.SelectedValue);
                dataGridView1.DataSource = db.Products.Where(p =>
               p.CategoryID == CategoryID).Select(p => new
               {
                   p.ProductID,
                   p.Name,
                   p.Quantity,
                   p.Price,
                   p.MarketPrice,
                   p.Description,
                   p.ImageFile,
                   p.Status
               }).ToList();
                lblNumOfProduct.Text = "Số sản phẩm: " + dataGridView1.Rows.Count;
            }

        }

        private void fManageProduct_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                cbCategories.DisplayMember = "Name";
                cbCategories.ValueMember = "CategoryID";
                //lệnh dưới đây nằm sau 2 lệnh trên
                cbCategories.DataSource =
                db.Categories.OrderBy(c => c.Order)
                .Select(c => new { c.CategoryID, c.Name })
                .ToList();
                //cbCategories.Text = null;
                //dataGridView1.Width = ClientSize.Width - 10;
            }

        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                if (ckCategory.Checked)
                    dataGridView1.DataSource = db.Products.Where(p =>
                   p.Name.Contains(txtName.Text) && (p.CategoryID == CategoryID ||
                   cbCategories.SelectedIndex < 0)).Select(p => new
                   {
                       p.ProductID,
                       p.Name,
                       p.Quantity,
                       p.Price,
                       p.MarketPrice,
                       p.Description,
                       p.ImageFile,
                       p.Status
                   }).ToList();
                else
                    dataGridView1.DataSource = db.Products.Where(p =>
                   p.Name.Contains(txtName.Text)).Select(p => new
                   {
                       p.ProductID,
                       p.Name,
                       p.Quantity,
                       p.Price,
                       p.MarketPrice,
                       p.Description,
                       p.ImageFile,
                       p.Status
                   }).ToList();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new EFDbContext())
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    try
                    {
                        long ProductID =
                        Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value);
                        Product product = db.Products.Single(c => c.ProductID == ProductID);
                        if (MessageBox.Show("Bạn muốn xóa sản phẩm " + product.Name, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Products.Remove(product);
                            db.SaveChanges();
                            fManageProduct_Activated(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    //if (Utility.IsOpeningForm("fEditProduct"))
                    // return;
                    fEditProduct f = new fEditProduct
                   (Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value));
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.ImageLocation = Utility.ImagePath +
            dataGridView1.Rows[e.RowIndex].Cells["ImageFile"].Value; // row sẽ lấy dòng , cells sẽ lấy cột , vakue lấy giá trị

        }

        private void btNew_Click(object sender, EventArgs e)
        {
            //if (Utility.IsOpeningForm("fNewProduct"))
            // return;
            fNewProduct f = new fNewProduct();
            f.MdiParent = this.MdiParent;
            f.Show();

        }

        private void ckCategory_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fManageProduct_Activated(object sender, EventArgs e)
        {
            cbCategories_SelectedIndexChanged(sender, e);
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
