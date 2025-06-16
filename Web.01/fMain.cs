namespace QLBH
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            Text = "Quản lý Bán hàng " + Utility.Employee.Name;
            if (Utility.Employee.RoleID == 1)
            {
                manageEmployeeToolStripMenuItem.Visible = true;
                newEmployeeToolStripMenuItem.Visible = true;
            }
            else if (Utility.Employee.RoleID == 2)
            {
                manageCustomerToolStripMenuItem.Visible = true;
                manageCategoryToolStripMenuItem.Visible = true;
                manageProductToolStripMenuItem.Visible = true;
                manageOrderToolStripMenuItem.Visible = true;
                reportToolStripMenuItem.Visible = true;
            }
            else if (Utility.Employee.RoleID == 3)
            {
                newCustomerToolStripMenuItem.Visible = true;
                newCategoryToolStripMenuItem.Visible = true;
                newProductToolStripMenuItem.Visible = true;
                newOrderToolStripMenuItem.Visible = true;
                processOrderDetailsToolStripMenuItem.Visible = true;
            }
            else if (Utility.Employee.RoleID == 4)
            {
                reportToolStripMenuItem.Visible = true;
            }

        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fMain_Click(object sender, EventArgs e)
        {

        }

        private void fMain_Load_1(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void manageEmployeeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fManageCustomer f = new fManageCustomer();
            f.MdiParent = this;
            f.Show();
        }

        private void manageCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Utility.IsOpeningForm("fManageProduct"))
            // return;
            fManageProduct f = new fManageProduct();
            f.MdiParent = this;
            f.Show();
        }

        private void manageOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Utility.IsOpeningForm("fManageOrder"))
            // return;
            fManageOrder f = new fManageOrder();
            f.MdiParent = this;
            f.Show();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Utility.IsOpeningForm("fNewOrder"))
            // return;
            fNewOrder f = new fNewOrder();
            f.MdiParent = this.MdiParent;
            f.Show();

        }

        private void processOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Utility.IsOpeningForm("fProcessOrderDetails"))
            // return;
            fProcessOrderDetails f = new fProcessOrderDetails();
            f.MdiParent = this;
            f.Show();
        }
    }
}
