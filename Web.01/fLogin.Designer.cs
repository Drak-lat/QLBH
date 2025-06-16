namespace QLBH
{
    partial class fLogin
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
            lblMessage = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btLogin = new Button();
            btClose = new Button();
            liForget = new LinkLabel();
            lbNguoidung = new Label();
            lbMatkhau = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(558, 255);
            lblMessage.Margin = new Padding(6, 0, 6, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(144, 30);
            lblMessage.TabIndex = 5;
            lblMessage.Text = " Chào bạn!";
            lblMessage.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(722, 342);
            txtUsername.Margin = new Padding(6, 6, 6, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(224, 39);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(722, 432);
            txtPassword.Margin = new Padding(6, 6, 6, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(224, 39);
            txtPassword.TabIndex = 1;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.Lime;
            btLogin.Location = new Point(722, 519);
            btLogin.Margin = new Padding(6, 6, 6, 6);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(228, 46);
            btLogin.TabIndex = 2;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.FromArgb(255, 128, 128);
            btClose.Location = new Point(722, 603);
            btClose.Margin = new Padding(6, 6, 6, 6);
            btClose.Name = "btClose";
            btClose.Size = new Size(228, 44);
            btClose.TabIndex = 3;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // liForget
            // 
            liForget.AutoSize = true;
            liForget.Location = new Point(460, 536);
            liForget.Margin = new Padding(6, 0, 6, 0);
            liForget.Name = "liForget";
            liForget.Size = new Size(200, 30);
            liForget.TabIndex = 4;
            liForget.TabStop = true;
            liForget.Text = "Quên mật khẩu";
            // 
            // lbNguoidung
            // 
            lbNguoidung.AutoSize = true;
            lbNguoidung.Location = new Point(532, 342);
            lbNguoidung.Margin = new Padding(6, 0, 6, 0);
            lbNguoidung.Name = "lbNguoidung";
            lbNguoidung.Size = new Size(151, 30);
            lbNguoidung.TabIndex = 6;
            lbNguoidung.Text = "Người dùng";
            // 
            // lbMatkhau
            // 
            lbMatkhau.AutoSize = true;
            lbMatkhau.Location = new Point(558, 442);
            lbMatkhau.Margin = new Padding(6, 0, 6, 0);
            lbMatkhau.Name = "lbMatkhau";
            lbMatkhau.Size = new Size(132, 30);
            lbMatkhau.TabIndex = 7;
            lbMatkhau.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(654, 148);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(432, 46);
            label1.TabIndex = 8;
            label1.Text = "Đăng Nhập Hệ Thống ";
            label1.Click += label1_Click_1;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(16F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1828, 900);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(lbMatkhau);
            Controls.Add(lbNguoidung);
            Controls.Add(liForget);
            Controls.Add(btClose);
            Controls.Add(btLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblMessage);
            Font = new Font("Kristen ITC", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 6, 6, 6);
            Name = "fLogin";
            Text = "Đăng nhập";
            Load += fLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btLogin;
        private Button btClose;
        private LinkLabel liForget;
        private Label lbNguoidung;
        private Label lbMatkhau;
        private Label label1;
    }
}