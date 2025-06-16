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
    public partial class fEditCustomer : Form
    {
        private EFDbContext db = new EFDbContext();
        private Customer customer;
        private long CustomerID;
        public fEditCustomer(long CustomerID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;
        }

        private void fEditCustomer_Load(object sender, EventArgs e)
        {
            customer = db.Customers.Single(p => p.CustomerID == CustomerID);
            Text = "SỬA ĐỔI KHÁCH HÀNG " + customer.CustomerID.ToString();
            txtName.Text = customer.Name;
            txtAddress.Text = customer.Address;
            txtPhone.Text = customer.Phone;
            txtEmail.Text = customer.Email;
            dateTimePicker1.Text = customer.BirthDate.ToString();
            ckGender.CheckState = customer.Gender == null ? CheckState.Indeterminate :
           (customer.Gender == true ? CheckState.Checked : CheckState.Unchecked);
            ckStatus.Checked = customer.Status;
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            try
            {
                customer.Name = txtName.Text;
                customer.Address = txtAddress.Text;
                customer.Phone = txtPhone.Text;
                customer.Email = txtEmail.Text;
                customer.BirthDate = dateTimePicker1.Value.Date;
                customer.Gender = ckGender.CheckState == CheckState.Indeterminate ?
               (bool?)null : ckGender.Checked;
                customer.Status = ckStatus.Checked;
                db.SaveChanges();
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }
            txtName.Focus();
        }
        private void btClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

