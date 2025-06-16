namespace QLBH
{
    partial class fManageCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btNew = new Button();
            btFind = new Button();
            txtName = new TextBox();
            dataGridView1 = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewCheckBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Delete = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btNew
            // 
            btNew.Location = new Point(12, 20);
            btNew.Name = "btNew";
            btNew.Size = new Size(102, 36);
            btNew.TabIndex = 0;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // btFind
            // 
            btFind.Location = new Point(678, 24);
            btFind.Name = "btFind";
            btFind.Size = new Size(110, 35);
            btFind.TabIndex = 1;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(540, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CustomerID, Name, Gender, BirthDate, Address, Phone, Email, Status, Delete, Edit });
            dataGridView1.Location = new Point(1, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(799, 386);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CustomerID
            // 
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.HeaderText = "CustomerID";
            CustomerID.Name = "CustomerID";
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            Gender.Resizable = DataGridViewTriState.True;
            Gender.SortMode = DataGridViewColumnSortMode.Automatic;
            Gender.ThreeState = true;
            // 
            // BirthDate
            // 
            BirthDate.DataPropertyName = "BirthDate";
            BirthDate.HeaderText = "BirthDate";
            BirthDate.Name = "BirthDate";
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.Name = "Address";
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Resizable = DataGridViewTriState.True;
            Status.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Delete
            // 
            Delete.DataPropertyName = "Delete";
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "Xóa ";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(174, 24);
            label1.Name = "label1";
            label1.Size = new Size(196, 24);
            label1.TabIndex = 4;
            label1.Text = "Quản lý khách hàng ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 36);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 5;
            label2.Text = "Tên khách hàng ";
            // 
            // fManageCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtName);
            Controls.Add(btFind);
            Controls.Add(btNew);
            Text = "Quản lý Khách";
            WindowState = FormWindowState.Maximized;
            Activated += fManageCustomer_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btNew;
        private Button btFind;
        private TextBox txtName;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewCheckBoxColumn Gender;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn Edit;
    }
}