namespace QLBH
{
    partial class fNewProduct
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
            txtName = new TextBox();
            txtImageFile = new TextBox();
            rDescription = new RichTextBox();
            mQuantity = new MaskedTextBox();
            mPrice = new MaskedTextBox();
            mMarketPrice = new MaskedTextBox();
            ckStatus = new CheckBox();
            cbCategories = new ComboBox();
            btSave = new Button();
            btClose = new Button();
            btBrowse = new Button();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(337, 23);
            txtName.TabIndex = 0;
            txtName.Validating += txtName_Validating;
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(430, 186);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(100, 23);
            txtImageFile.TabIndex = 1;
            txtImageFile.Validating += txtImageFile_Validating;
            // 
            // rDescription
            // 
            rDescription.Location = new Point(113, 173);
            rDescription.Name = "rDescription";
            rDescription.Size = new Size(205, 192);
            rDescription.TabIndex = 2;
            rDescription.Text = "";
            rDescription.Validating += rDescription_Validating;
            // 
            // mQuantity
            // 
            mQuantity.Location = new Point(113, 95);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(107, 23);
            mQuantity.TabIndex = 3;
            mQuantity.TypeValidationCompleted += mQuantity_TypeValidationCompleted;
            // 
            // mPrice
            // 
            mPrice.Location = new Point(307, 95);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(125, 23);
            mPrice.TabIndex = 4;
            mPrice.TypeValidationCompleted += mPrice_TypeValidationCompleted;
            // 
            // mMarketPrice
            // 
            mMarketPrice.Location = new Point(577, 95);
            mMarketPrice.Name = "mMarketPrice";
            mMarketPrice.Size = new Size(107, 23);
            mMarketPrice.TabIndex = 5;
            mMarketPrice.MaskInputRejected += mMarketPrice_MaskInputRejected;
            mMarketPrice.TypeValidationCompleted += mMarketPrice_TypeValidationCompleted;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Location = new Point(699, 34);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(78, 19);
            ckStatus.TabIndex = 6;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // cbCategories
            // 
            cbCategories.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(563, 32);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(121, 23);
            cbCategories.TabIndex = 7;
            cbCategories.Validating += cbCategories_Validating;
            // 
            // btSave
            // 
            btSave.Location = new Point(713, 198);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 35);
            btSave.TabIndex = 8;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(713, 239);
            btClose.Name = "btClose";
            btClose.Size = new Size(75, 39);
            btClose.TabIndex = 9;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btBrowse
            // 
            btBrowse.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBrowse.Location = new Point(536, 186);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(46, 23);
            btBrowse.TabIndex = 10;
            btBrowse.Text = "...";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(588, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 12;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 13;
            label2.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 186);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 14;
            label3.Text = "Mô tả ngắn ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(240, 99);
            label4.Name = "label4";
            label4.Size = new Size(61, 19);
            label4.TabIndex = 15;
            label4.Text = "Giá bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(453, 99);
            label5.Name = "label5";
            label5.Size = new Size(104, 19);
            label5.TabIndex = 16;
            label5.Text = "Giá thị trường";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(517, 32);
            label6.Name = "label6";
            label6.Size = new Size(39, 19);
            label6.TabIndex = 17;
            label6.Text = "Loại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(336, 186);
            label7.Name = "label7";
            label7.Size = new Size(88, 19);
            label7.TabIndex = 18;
            label7.Text = "Tệp tin hình";
            // 
            // fNewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
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
            Name = "fNewProduct";
            Text = "Nhập thêm sản phẩm mới";
            WindowState = FormWindowState.Maximized;
            Load += fNewProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtImageFile;
        private RichTextBox rDescription;
        private MaskedTextBox mQuantity;
        private MaskedTextBox mPrice;
        private MaskedTextBox mMarketPrice;
        private CheckBox ckStatus;
        private ComboBox cbCategories;
        private Button btSave;
        private Button btClose;
        private Button btBrowse;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}