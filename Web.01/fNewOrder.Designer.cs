namespace QLBH
{
    partial class fNewOrder
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
            components = new System.ComponentModel.Container();
            txtReceiveAddress = new TextBox();
            dtOrderDate = new DateTimePicker();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dtReceiveDate = new DateTimePicker();
            dtOrderTime = new DateTimePicker();
            dtReceiveTime = new DateTimePicker();
            cbEmployees = new ComboBox();
            cbProgresses = new ComboBox();
            cbCustomers = new ComboBox();
            btSave = new Button();
            btClose = new Button();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // txtReceiveAddress
            // 
            txtReceiveAddress.Location = new Point(328, 104);
            txtReceiveAddress.Margin = new Padding(3, 4, 3, 4);
            txtReceiveAddress.Name = "txtReceiveAddress";
            txtReceiveAddress.Size = new Size(574, 27);
            txtReceiveAddress.TabIndex = 1;
            // 
            // dtOrderDate
            // 
            dtOrderDate.CustomFormat = "dd//MM//yy";
            dtOrderDate.Format = DateTimePickerFormat.Custom;
            dtOrderDate.Location = new Point(12, 256);
            dtOrderDate.Margin = new Padding(3, 4, 3, 4);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(145, 27);
            dtOrderDate.TabIndex = 4;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dtReceiveDate
            // 
            dtReceiveDate.CustomFormat = "dd//MM//yy";
            dtReceiveDate.Format = DateTimePickerFormat.Custom;
            dtReceiveDate.Location = new Point(339, 256);
            dtReceiveDate.Margin = new Padding(3, 4, 3, 4);
            dtReceiveDate.Name = "dtReceiveDate";
            dtReceiveDate.Size = new Size(145, 27);
            dtReceiveDate.TabIndex = 2;
            // 
            // dtOrderTime
            // 
            dtOrderTime.CustomFormat = "hh:mm:ss";
            dtOrderTime.Format = DateTimePickerFormat.Custom;
            dtOrderTime.Location = new Point(181, 256);
            dtOrderTime.Margin = new Padding(3, 4, 3, 4);
            dtOrderTime.Name = "dtOrderTime";
            dtOrderTime.ShowUpDown = true;
            dtOrderTime.Size = new Size(145, 27);
            dtOrderTime.TabIndex = 5;
            // 
            // dtReceiveTime
            // 
            dtReceiveTime.CustomFormat = "hh:mm:ss";
            dtReceiveTime.Format = DateTimePickerFormat.Custom;
            dtReceiveTime.Location = new Point(505, 255);
            dtReceiveTime.Margin = new Padding(3, 4, 3, 4);
            dtReceiveTime.Name = "dtReceiveTime";
            dtReceiveTime.ShowUpDown = true;
            dtReceiveTime.Size = new Size(145, 27);
            dtReceiveTime.TabIndex = 3;
            // 
            // cbEmployees
            // 
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new Point(675, 255);
            cbEmployees.Margin = new Padding(3, 4, 3, 4);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new Size(225, 28);
            cbEmployees.TabIndex = 6;
            // 
            // cbProgresses
            // 
            cbProgresses.FormattingEnabled = true;
            cbProgresses.Location = new Point(14, 376);
            cbProgresses.Margin = new Padding(3, 4, 3, 4);
            cbProgresses.Name = "cbProgresses";
            cbProgresses.Size = new Size(145, 28);
            cbProgresses.TabIndex = 9;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(12, 104);
            cbCustomers.Margin = new Padding(3, 4, 3, 4);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(293, 28);
            cbCustomers.TabIndex = 0;
            cbCustomers.SelectionChangeCommitted += cbCustomers_SelectionChangeCommitted;
            // 
            // btSave
            // 
            btSave.Location = new Point(181, 373);
            btSave.Margin = new Padding(3, 4, 3, 4);
            btSave.Name = "btSave";
            btSave.Size = new Size(96, 33);
            btSave.TabIndex = 7;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(306, 373);
            btClose.Margin = new Padding(3, 4, 3, 4);
            btClose.Name = "btClose";
            btClose.Size = new Size(89, 35);
            btClose.TabIndex = 8;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 69);
            label1.Name = "label1";
            label1.Size = new Size(108, 23);
            label1.TabIndex = 10;
            label1.Text = "Khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(484, 69);
            label2.Name = "label2";
            label2.Size = new Size(158, 23);
            label2.TabIndex = 11;
            label2.Text = "Địa chỉ giao hàng ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(459, 195);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 12;
            label3.Text = "Giao hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 228);
            label4.Name = "label4";
            label4.Size = new Size(158, 23);
            label4.TabIndex = 13;
            label4.Text = "Ngày/Tháng/Năm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(131, 195);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 14;
            label5.Text = "Đặt hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(181, 228);
            label6.Name = "label6";
            label6.Size = new Size(137, 23);
            label6.TabIndex = 15;
            label6.Text = "Giờ:Phút:Giây";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(339, 228);
            label7.Name = "label7";
            label7.Size = new Size(158, 23);
            label7.TabIndex = 16;
            label7.Text = "Ngày/Tháng/Năm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(505, 228);
            label8.Name = "label8";
            label8.Size = new Size(137, 23);
            label8.TabIndex = 17;
            label8.Text = "Giờ:Phút:Giây";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(675, 228);
            label9.Name = "label9";
            label9.Size = new Size(93, 23);
            label9.TabIndex = 18;
            label9.Text = "Nhân viên";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(14, 332);
            label10.Name = "label10";
            label10.Size = new Size(94, 23);
            label10.TabIndex = 19;
            label10.Text = "Tiến trình";
            // 
            // fNewOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            ControlBox = false;
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(cbCustomers);
            Controls.Add(cbProgresses);
            Controls.Add(cbEmployees);
            Controls.Add(dtReceiveTime);
            Controls.Add(dtOrderTime);
            Controls.Add(dtReceiveDate);
            Controls.Add(dtOrderDate);
            Controls.Add(txtReceiveAddress);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fNewOrder";
            Text = "Nhập thêm đơn hàng mới";
            WindowState = FormWindowState.Maximized;
            Load += fNewOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtReceiveAddress;
        private DateTimePicker dtOrderDate;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DateTimePicker dtReceiveDate;
        private DateTimePicker dtOrderTime;
        private DateTimePicker dtReceiveTime;
        private ComboBox cbEmployees;
        private ComboBox cbProgresses;
        private ComboBox cbCustomers;
        private Button btSave;
        private Button btClose;
        private ToolTip toolTip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}