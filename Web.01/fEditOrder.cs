using Microsoft.EntityFrameworkCore;
using QLBH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class fEditOrder : Form
    {
        private Order order;
        private long OrderID;
        private EFDbContext db = new EFDbContext();
        public fEditOrder(long OrderID)
        {
            InitializeComponent();
            this.OrderID = OrderID;
        }

        private void fEditOrder_Load(object sender, EventArgs e)
        {
            order = db.Orders.Include(o => o.Customer).Include(o => o.Employee).Single(o => o.OrderID == OrderID);
            Text = "Sửa đơn hàng " + order.OrderID.ToString();
            txtReceiveAddress.Text = order.ReceiveAddress;
            dtOrderDate.Text = order.OrderDate.ToString();
            dtReceiveDate.Text = order.ReceiveDate.ToString();
            dtOrderTime.Text = order.OrderTime.ToString();
            dtReceiveTime.Text = order.ReceiveTime.ToString();
            cbProgresses.DisplayMember = "Name";
            cbProgresses.ValueMember = "ProgressID";
            cbProgresses.DataSource = db.Progresses.ToList();
            cbProgresses.Text = order.Progress.Name;
            cbCustomers.DisplayMember = "Name";
            cbCustomers.ValueMember = "CustomerID";
            cbCustomers.DataSource = db.Customers.Select(c => new
            {
                c.CustomerID,
                c.Name
            }).ToList();
            cbCustomers.Text = order.Customer.Name;
            cbEmployees.DisplayMember = "Name";
            cbEmployees.ValueMember = "EmployeeID";
            cbEmployees.DataSource = db.Employees.Select(c => new
            {
                c.EmployeeID,
                c.Name
            }).ToList();
            cbEmployees.Text = order.Employee.Name;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            long CustomerID = Convert.ToInt64(cbCustomers.SelectedValue);
            txtReceiveAddress.Text = db.Customers.Single(c => c.CustomerID == CustomerID).Address;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtOrderDate.Value.ToShortDateString() + " " + dtOrderTime.Value.TimeOfDay)
            > Convert.ToDateTime(dtReceiveDate.Value.ToShortDateString() + " " + dtReceiveTime.Value.TimeOfDay))
            {
                toolTip1.Show("Thời điểm đặt hàng phải <= Thời điểm nhận hàng?", dtReceiveDate, 0, 0, 1000);
                dtReceiveDate.Focus();
                return;
            }
            try
            {
                order.ReceiveAddress = txtReceiveAddress.Text;
                order.OrderDate = dtOrderDate.Value.Date;
                order.OrderTime = dtOrderTime.Value.TimeOfDay;
                order.ReceiveDate = dtReceiveDate.Value.Date;
                order.ReceiveTime = dtReceiveTime.Value.TimeOfDay;
                order.ProgressID = Convert.ToByte(cbProgresses.SelectedValue);
                order.CustomerID = Convert.ToInt64(cbCustomers.SelectedValue);
                order.EmployeeID = Convert.ToInt64(cbEmployees.SelectedValue);
                db.SaveChanges();
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
