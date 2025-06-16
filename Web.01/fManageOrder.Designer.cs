namespace QLBH
{
    partial class fManageOrder
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
            cbMonth = new ComboBox();
            cbYear = new ComboBox();
            btNew = new Button();
            btFind = new Button();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            OrderTime = new DataGridViewTextBoxColumn();
            ReceiveDate = new DataGridViewTextBoxColumn();
            ReceiveTime = new DataGridViewTextBoxColumn();
            ReceiveAddress = new DataGridViewTextBoxColumn();
            ProgressID = new DataGridViewTextBoxColumn();
            ProgressName = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            EmployeeID = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            lblNumOfOrder = new Label();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Location = new Point(426, 109);
            cbMonth.Margin = new Padding(3, 4, 3, 4);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(97, 28);
            cbMonth.TabIndex = 1;
            cbMonth.Text = "Tháng";
            cbMonth.UseWaitCursor = true;
            cbMonth.SelectedIndexChanged += cbMonth_SelectedIndexChanged;
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(311, 109);
            cbYear.Margin = new Padding(3, 4, 3, 4);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(97, 28);
            cbYear.TabIndex = 0;
            cbYear.Text = "Năm";
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
            // 
            // btNew
            // 
            btNew.Location = new Point(14, 109);
            btNew.Margin = new Padding(3, 4, 3, 4);
            btNew.Name = "btNew";
            btNew.Size = new Size(86, 30);
            btNew.TabIndex = 4;
            btNew.Text = "Nhập mới ";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // btFind
            // 
            btFind.Location = new Point(804, 110);
            btFind.Margin = new Padding(3, 4, 3, 4);
            btFind.Name = "btFind";
            btFind.Size = new Size(78, 30);
            btFind.TabIndex = 3;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(650, 111);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(148, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderID, OrderDate, OrderTime, ReceiveDate, ReceiveTime, ReceiveAddress, ProgressID, ProgressName, CustomerID, EmployeeID, Edit, Delete });
            dataGridView1.Location = new Point(-3, 167);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(922, 432);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // OrderID
            // 
            OrderID.DataPropertyName = "OrderID";
            OrderID.HeaderText = "OrderID";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            OrderID.Width = 91;
            // 
            // OrderDate
            // 
            OrderDate.DataPropertyName = "OrderDate";
            OrderDate.HeaderText = "OrderDate";
            OrderDate.MinimumWidth = 6;
            OrderDate.Name = "OrderDate";
            OrderDate.Width = 108;
            // 
            // OrderTime
            // 
            OrderTime.DataPropertyName = "OrderTime";
            OrderTime.HeaderText = "OrderTime";
            OrderTime.MinimumWidth = 6;
            OrderTime.Name = "OrderTime";
            OrderTime.Width = 109;
            // 
            // ReceiveDate
            // 
            ReceiveDate.DataPropertyName = "ReceiveDate";
            ReceiveDate.HeaderText = "ReceiveDate";
            ReceiveDate.MinimumWidth = 6;
            ReceiveDate.Name = "ReceiveDate";
            ReceiveDate.Width = 121;
            // 
            // ReceiveTime
            // 
            ReceiveTime.DataPropertyName = "ReceiveTime";
            ReceiveTime.HeaderText = "ReceiveTime";
            ReceiveTime.MinimumWidth = 6;
            ReceiveTime.Name = "ReceiveTime";
            ReceiveTime.Width = 122;
            // 
            // ReceiveAddress
            // 
            ReceiveAddress.DataPropertyName = "ReceiveAddress";
            ReceiveAddress.HeaderText = "ReceiveAddress";
            ReceiveAddress.MinimumWidth = 6;
            ReceiveAddress.Name = "ReceiveAddress";
            ReceiveAddress.Width = 142;
            // 
            // ProgressID
            // 
            ProgressID.DataPropertyName = "ProgressID";
            ProgressID.HeaderText = "ProgressID";
            ProgressID.MinimumWidth = 6;
            ProgressID.Name = "ProgressID";
            ProgressID.Width = 109;
            // 
            // ProgressName
            // 
            ProgressName.DataPropertyName = "ProgressName";
            ProgressName.HeaderText = "ProgressName";
            ProgressName.MinimumWidth = 6;
            ProgressName.Name = "ProgressName";
            ProgressName.Width = 134;
            // 
            // CustomerID
            // 
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.HeaderText = "CustomerID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 116;
            // 
            // EmployeeID
            // 
            EmployeeID.DataPropertyName = "EmployeeID";
            EmployeeID.HeaderText = "EmployeeID";
            EmployeeID.MinimumWidth = 6;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Width = 119;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 41;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 59;
            // 
            // lblNumOfOrder
            // 
            lblNumOfOrder.AutoSize = true;
            lblNumOfOrder.Location = new Point(106, 115);
            lblNumOfOrder.Name = "lblNumOfOrder";
            lblNumOfOrder.Size = new Size(128, 20);
            lblNumOfOrder.TabIndex = 7;
            lblNumOfOrder.Text = "Số lượng hóa đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(546, 115);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 8;
            label3.Text = "Ngày đặt hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 26);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 9;
            label1.Text = "Quản lý Đơn Hàng";
            // 
            // fManageOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(lblNumOfOrder);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(btFind);
            Controls.Add(btNew);
            Controls.Add(cbYear);
            Controls.Add(cbMonth);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fManageOrder";
            Text = "Quản lý Đơn hàng";
            WindowState = FormWindowState.Maximized;
            Activated += fManageOrder_Activated;
            Load += fManageOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMonth;
        private ComboBox cbYear;
        private Button btNew;
        private Button btFind;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn OrderTime;
        private DataGridViewTextBoxColumn ReceiveDate;
        private DataGridViewTextBoxColumn ReceiveTime;
        private DataGridViewTextBoxColumn ReceiveAddress;
        private DataGridViewTextBoxColumn ProgressID;
        private DataGridViewTextBoxColumn ProgressName;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Label lblNumOfOrder;
        private Label label3;
        private Label label1;
    }
}