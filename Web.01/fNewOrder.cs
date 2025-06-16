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
    public partial class fNewOrder : Form
    {
        private Order order;
        public fNewOrder()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fNewOrder_Load(object sender, EventArgs e)
        {
            cbCustomers.DisplayMember = "Name";
            cbCustomers.ValueMember = "CustomerID";
            cbEmployees.DisplayMember = "Name";
            cbEmployees.ValueMember = "EmployeeID";
            using (var db = new EFDbContext())
            {
                cbCustomers.DataSource = db.Customers.Select(c => new
                {
                    c.CustomerID,
                    c.Name
                }).ToList();
                cbEmployees.DataSource = db.Employees.Select(e => new
                {
                    e.EmployeeID,
                    e.Name
                }).ToList();
            }
            cbCustomers.Text = null;
            cbEmployees.Text = null;
        }

        private void cbCustomers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                long CustomerID = Convert.ToInt64(cbCustomers.SelectedValue);
                txtReceiveAddress.Text = db.Customers.Single(c => c.CustomerID ==
               CustomerID).Address;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtOrderDate.Value.ToShortDateString() + " " + dtOrderTime.Value.TimeOfDay) >
                Convert.ToDateTime(dtReceiveDate.Value.ToShortDateString() + " " + dtReceiveTime.Value.TimeOfDay))
            {
                toolTip1.Show("Thời điểm đặt hàng phải <= Thời điểm nhận hàng?", dtReceiveDate, 0, 0, 1000);
                dtReceiveDate.Focus();
                return;
            }
            try
            {
                order = new Order();
                order.ReceiveAddress = txtReceiveAddress.Text;
                order.OrderDate = dtOrderDate.Value.Date;
                order.ReceiveDate = dtReceiveDate.Value.Date;
                order.OrderTime = dtOrderTime.Value.TimeOfDay;
                order.ReceiveTime = dtReceiveTime.Value.TimeOfDay;
                order.ProgressID = 1;
                order.CustomerID = Convert.ToInt64(cbCustomers.SelectedValue);
                order.EmployeeID = Convert.ToInt64(cbEmployees.SelectedValue);
                using (var db = new EFDbContext())
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                }
                txtReceiveAddress.Text = null;
                cbProgresses.Text = "1";
                cbCustomers.Text = null;
                cbEmployees.Text = null;
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }

        }

    }
}
