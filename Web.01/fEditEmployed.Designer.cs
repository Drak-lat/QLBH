namespace QLBH
{
    partial class fEditEmployed
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
            toolTip1 = new ToolTip(components);
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btClose = new Button();
            btSave = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dateTimePicker1 = new DateTimePicker();
            ckStatus = new CheckBox();
            ckGender = new CheckBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 309);
            label6.Name = "label6";
            label6.Size = new Size(240, 26);
            label6.TabIndex = 30;
            label6.Text = "Ngày/Tháng/Năm sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, 336);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(443, 236);
            label4.Name = "label4";
            label4.Size = new Size(73, 26);
            label4.TabIndex = 28;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 236);
            label3.Name = "label3";
            label3.Size = new Size(125, 26);
            label3.TabIndex = 27;
            label3.Text = "Điện Thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 169);
            label2.Name = "label2";
            label2.Size = new Size(91, 26);
            label2.TabIndex = 26;
            label2.Text = "Địa Chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 99);
            label1.Name = "label1";
            label1.Size = new Size(187, 26);
            label1.TabIndex = 25;
            label1.Text = "Tên Khách Hàng";
            // 
            // btClose
            // 
            btClose.Location = new Point(707, 309);
            btClose.Margin = new Padding(3, 4, 3, 4);
            btClose.Name = "btClose";
            btClose.Size = new Size(105, 31);
            btClose.TabIndex = 24;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            btSave.Location = new Point(545, 308);
            btSave.Margin = new Padding(3, 4, 3, 4);
            btSave.Name = "btSave";
            btSave.Size = new Size(114, 32);
            btSave.TabIndex = 23;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(251, 308);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(166, 27);
            dateTimePicker1.TabIndex = 22;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Location = new Point(691, 103);
            ckStatus.Margin = new Padding(3, 4, 3, 4);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(97, 24);
            ckStatus.TabIndex = 18;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.CheckAlign = ContentAlignment.MiddleRight;
            ckGender.Checked = true;
            ckGender.CheckState = CheckState.Indeterminate;
            ckGender.Location = new Point(591, 103);
            ckGender.Margin = new Padding(3, 4, 3, 4);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(87, 24);
            ckGender.TabIndex = 17;
            ckGender.Text = "Giới tính";
            ckGender.ThreeState = true;
            ckGender.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(522, 233);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(266, 27);
            txtEmail.TabIndex = 21;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(183, 233);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(234, 27);
            txtPhone.TabIndex = 20;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(183, 168);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(605, 27);
            txtAddress.TabIndex = 19;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(226, 101);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(364, 27);
            txtName.TabIndex = 16;
            // 
            // fEditEmployed
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(dateTimePicker1);
            Controls.Add(ckStatus);
            Controls.Add(ckGender);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Name = "fEditEmployed";
            Text = "Sửa nhân viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btClose;
        private Button btSave;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DateTimePicker dateTimePicker1;
        private CheckBox ckStatus;
        private CheckBox ckGender;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtName;
    }
}