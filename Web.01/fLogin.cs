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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập tên người dùng?";
                txtUsername.Focus();
            }
            else
                 if (txtPassword.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập mật khẩu?";
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    using (var db = new EFDbContext())
                    {
                        Utility.Employee = db.Employees.SingleOrDefault(e =>
                       e.Email == txtUsername.Text && e.Password == txtPassword.Text);
                        if (Utility.Employee == null) //Nếu đăng nhập thất bại
                        {
                            lblMessage.Text = "Sai tên người dùng hoặc mật khẩu";
                            txtUsername.Focus();
                        }
                        else
                            DialogResult = DialogResult.OK; //đóng form
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Lỗi";
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
