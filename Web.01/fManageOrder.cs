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
    public partial class fManageOrder : Form
    {
        public fManageOrder()
        {
            InitializeComponent();
        }

        private void fManageOrder_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year + 1; i >= 2015; i--)
                cbYear.Items.Add(i);
            dataGridView1.Width = ClientSize.Width - 10;
            cbMonth.Items.Add("Tất cả");
            for (int i = 1; i < 13; i++)
                cbMonth.Items.Add(i);
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year;
            if (!int.TryParse(cbYear.Text, out year))
            {
                year = DateTime.Now.Year; // Nếu không thể chuyển đổi, dùng năm hiện tại
            }

            byte month;
            if (cbMonth.Text == "Tất cả")
            {
                month = 0;
            }
            else if (!byte.TryParse(cbMonth.Text, out month))
            {
                month = (byte)DateTime.Now.Month; // Nếu không thể chuyển đổi, dùng tháng hiện tại
            }
            using (var db = new EFDbContext())
            {
                if (month == 0)
                    dataGridView1.DataSource = db.Orders.Where(o => o.OrderDate.Year ==
                   year).Select(o => new {
                       o.OrderID,
                       o.OrderDate,
                       o.OrderTime,
                       o.ReceiveDate,
                       o.ReceiveTime,
                       o.ReceiveAddress,
                       o.ProgressID,
                       ProgressName = o.Progress.Name,
                       o.CustomerID,
                       o.EmployeeID
                   }).ToList();
                else
                    dataGridView1.DataSource = db.Orders.Where(o => o.OrderDate.Year == year
                   && o.OrderDate.Month == month).Select(o => new {
                       o.OrderID,
                       o.OrderDate,
                       o.OrderTime,
                       o.ReceiveDate,
                       o.ReceiveTime,
                       o.ReceiveAddress,
                       o.ProgressID,
                       ProgressName =
                   o.Progress.Name,
                       o.CustomerID,
                       o.EmployeeID
                   }).ToList();
            }
            lblNumOfOrder.Text = "Số đơn hàng: " + dataGridView1.Rows.Count;
        }


        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMonth_SelectedIndexChanged(sender, e);
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                DateTime OrderDate = dateTimePicker1.Value.Date;
                dataGridView1.DataSource = db.Orders.Where(o => o.OrderDate == OrderDate ||
               OrderDate == null).Select(o => new
               {
                   o.OrderID,
                   o.OrderDate,
                   o.OrderTime,
                   o.ReceiveDate,
                   o.ReceiveTime,
                   o.ReceiveAddress,
                   o.ProgressID,
                   ProgressName =
               o.Progress.Name,
                   o.CustomerID,
                   o.EmployeeID
               }).ToList();
            }

        }

        private void fManageOrder_Activated(object sender, EventArgs e)
        {
            cbMonth_SelectedIndexChanged(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long OrderID =
                   Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Order order = db.Orders.Single(c => c.OrderID == OrderID);
                        if (MessageBox.Show("Bạn muốn xóa đơn hàng " + order.OrderID, "Xóa",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Orders.Remove(order);
                            db.SaveChanges();
                            fManageOrder_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                //if (Utility.IsOpeningForm("fEditOrder"))
                // return;
                fEditOrder f = new fEditOrder(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            //if (Utility.IsOpeningForm("fNewOrder"))
            // return;
            fNewOrder f = new fNewOrder();
            f.MdiParent = this.MdiParent;
            f.Show();
        }
    }

}
