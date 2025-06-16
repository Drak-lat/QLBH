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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBH
{
    public partial class fNewCustomer : Form
    {
        private Customer customer;
        public fNewCustomer()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ckGender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo khách hàng mới
                customer = new Customer();
                customer.Name = txtName.Text;
                customer.Address = txtAddress.Text;
                customer.Phone = txtPhone.Text;
                customer.Email = txtEmail.Text;
                customer.BirthDate = dateTimePicker1.Value.Date;
                customer.Gender = ckGender.CheckState == CheckState.Indeterminate ? (bool?)null : ckGender.Checked;
                customer.Status = ckStatus.Checked;

                using (var db = new EFDbContext())
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                }

                // Xóa trống và thiết lập lại các điều khiển
                txtName.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtEmail.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Today;
                ckGender.CheckState = CheckState.Indeterminate;
                ckStatus.Checked = true;

                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại! Error: " + ex.Message, btSave, 0, 0, 1000);
            }

            txtName.Focus();
        }
    }
}
