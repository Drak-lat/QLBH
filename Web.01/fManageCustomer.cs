using QLBH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class fManageCustomer : Form
    {
        public fManageCustomer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long CustomerID = Convert.ToInt64(dataGridView1
                    .Rows[e.RowIndex].Cells["CustomerID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Customer customer =
                        db.Customers.Single(c => c.CustomerID == CustomerID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + customer.Name,
                        "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                        {
                            db.Customers.Remove(customer);
                            db.SaveChanges();
                            fManageCustomer_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                 fEditCustomer f = new fEditCustomer(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["CustomerID"].Value));
                 f.MdiParent = this.MdiParent;
                 f.Show();
            }
        }

        private void fManageCustomer_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Customers.Select(c => new
                {
                    c.CustomerID,
                    c.Name,
                    c.Gender,
                    c.BirthDate,
                    c.Address,
                    c.Phone,
                    c.Email,
                    c.Status
                }).ToList();
            }

        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Customers.Select(c => new
                {
                    c.CustomerID,
                    c.Name,
                    c.Gender,
                    c.BirthDate,
                    c.Address,
                    c.Phone,
                    c.Email,
                    c.Status
                }).Where(c =>
                    c.Name.Contains(txtName.Text)).ToList();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            //if (Utility.IsOpeningForm("fNewCustomer"))
            // return;
            fNewCustomer f = new fNewCustomer();
            f.MdiParent = this.MdiParent;
            f.Show();
        }
    }
}
