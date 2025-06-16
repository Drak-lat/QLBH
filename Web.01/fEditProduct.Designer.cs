namespace QLBH
{
    partial class fEditProduct
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
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            openFileDialog1 = new OpenFileDialog();
            label6 = new Label();
            btBrowse = new Button();
            btClose = new Button();
            btSave = new Button();
            cbCategories = new ComboBox();
            ckStatus = new CheckBox();
            mMarketPrice = new MaskedTextBox();
            mPrice = new MaskedTextBox();
            mQuantity = new MaskedTextBox();
            rDescription = new RichTextBox();
            txtImageFile = new TextBox();
            txtName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(387, 284);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 37;
            label7.Text = "Tệp tin hình";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(521, 168);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 35;
            label5.Text = "Giá thị trường";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(278, 168);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 34;
            label4.Text = "Giá bán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 284);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 33;
            label3.Text = "Mô tả ngắn ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 168);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 32;
            label2.Text = "Số lượng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 84);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 31;
            label1.Text = "Tên sản phẩm";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(675, 267);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(594, 79);
            label6.Name = "label6";
            label6.Size = new Size(48, 23);
            label6.TabIndex = 36;
            label6.Text = "Loại";
            // 
            // btBrowse
            // 
            btBrowse.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBrowse.Location = new Point(616, 284);
            btBrowse.Margin = new Padding(3, 4, 3, 4);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(53, 31);
            btBrowse.TabIndex = 29;
            btBrowse.Text = "...";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(818, 355);
            btClose.Margin = new Padding(3, 4, 3, 4);
            btClose.Name = "btClose";
            btClose.Size = new Size(86, 52);
            btClose.TabIndex = 28;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(818, 300);
            btSave.Margin = new Padding(3, 4, 3, 4);
            btSave.Name = "btSave";
            btSave.Size = new Size(86, 47);
            btSave.TabIndex = 27;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // cbCategories
            // 
            cbCategories.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(647, 79);
            cbCategories.Margin = new Padding(3, 4, 3, 4);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(138, 28);
            cbCategories.TabIndex = 26;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Location = new Point(802, 81);
            ckStatus.Margin = new Padding(3, 4, 3, 4);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(97, 24);
            ckStatus.TabIndex = 25;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // mMarketPrice
            // 
            mMarketPrice.Location = new Point(663, 163);
            mMarketPrice.Margin = new Padding(3, 4, 3, 4);
            mMarketPrice.Name = "mMarketPrice";
            mMarketPrice.Size = new Size(122, 27);
            mMarketPrice.TabIndex = 24;
            // 
            // mPrice
            // 
            mPrice.Location = new Point(354, 163);
            mPrice.Margin = new Padding(3, 4, 3, 4);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(142, 27);
            mPrice.TabIndex = 23;
            // 
            // mQuantity
            // 
            mQuantity.Location = new Point(133, 163);
            mQuantity.Margin = new Padding(3, 4, 3, 4);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(122, 27);
            mQuantity.TabIndex = 22;
            // 
            // rDescription
            // 
            rDescription.Location = new Point(133, 267);
            rDescription.Margin = new Padding(3, 4, 3, 4);
            rDescription.Name = "rDescription";
            rDescription.Size = new Size(234, 255);
            rDescription.TabIndex = 21;
            rDescription.Text = "";
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(495, 284);
            txtImageFile.Margin = new Padding(3, 4, 3, 4);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(114, 27);
            txtImageFile.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 81);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(385, 27);
            txtName.TabIndex = 19;
            // 
            // fEditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(btBrowse);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(cbCategories);
            Controls.Add(ckStatus);
            Controls.Add(mMarketPrice);
            Controls.Add(mPrice);
            Controls.Add(mQuantity);
            Controls.Add(rDescription);
            Controls.Add(txtImageFile);
            Controls.Add(txtName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fEditProduct";
            Text = "Sửa đổi Sản phẩm ";
            WindowState = FormWindowState.Maximized;
            Load += fEditProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog1;
        private Label label6;
        private Button btBrowse;
        private Button btClose;
        private Button btSave;
        private ComboBox cbCategories;
        private CheckBox ckStatus;
        private MaskedTextBox mMarketPrice;
        private MaskedTextBox mPrice;
        private MaskedTextBox mQuantity;
        private RichTextBox rDescription;
        private TextBox txtImageFile;
        private TextBox txtName;
    }
}