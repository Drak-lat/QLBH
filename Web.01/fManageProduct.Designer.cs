namespace QLBH
{
    partial class fManageProduct
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btNew = new Button();
            cbCategories = new ComboBox();
            txtName = new TextBox();
            label1 = new Label();
            btFind = new Button();
            ckCategory = new CheckBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            MarketPrice = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ImageFile = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Delete = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            lblNumOfProduct = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btNew
            // 
            btNew.Location = new Point(12, 88);
            btNew.Name = "btNew";
            btNew.Size = new Size(76, 36);
            btNew.TabIndex = 5;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // cbCategories
            // 
            cbCategories.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(103, 58);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(121, 23);
            cbCategories.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(526, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(141, 23);
            txtName.TabIndex = 2;
            txtName.Validating += txtName_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 61);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 3;
            label1.Text = "Tên sản phẩm";
            // 
            // btFind
            // 
            btFind.Location = new Point(673, 53);
            btFind.Name = "btFind";
            btFind.Size = new Size(82, 27);
            btFind.TabIndex = 3;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // ckCategory
            // 
            ckCategory.AutoSize = true;
            ckCategory.CheckAlign = ContentAlignment.MiddleRight;
            ckCategory.Checked = true;
            ckCategory.CheckState = CheckState.Checked;
            ckCategory.Location = new Point(506, 95);
            ckCategory.Name = "ckCategory";
            ckCategory.Size = new Size(185, 19);
            ckCategory.TabIndex = 4;
            ckCategory.Text = "Tìm theo loại sản phẩm và tên";
            ckCategory.UseVisualStyleBackColor = true;
            ckCategory.CheckedChanged += ckCategory_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 61);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 6;
            label2.Text = "Chọn loại ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductID, Name, Quantity, Price, MarketPrice, Description, ImageFile, Status, Delete, Edit });
            dataGridView1.Location = new Point(-5, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(810, 300);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductID.DataPropertyName = "ProductID";
            ProductID.HeaderText = "ProductID";
            ProductID.Name = "ProductID";
            ProductID.Width = 85;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Name.DataPropertyName = "Name";
            Name.HeaderText = "ProductName";
            Name.Name = "Name";
            Name.Width = 106;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            Quantity.DefaultCellStyle = dataGridViewCellStyle1;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.Width = 78;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Price.DataPropertyName = "Price";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Price.DefaultCellStyle = dataGridViewCellStyle2;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.Width = 58;
            // 
            // MarketPrice
            // 
            MarketPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MarketPrice.DataPropertyName = "MarketPrice";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            MarketPrice.DefaultCellStyle = dataGridViewCellStyle3;
            MarketPrice.HeaderText = "MarketPrice";
            MarketPrice.Name = "MarketPrice";
            MarketPrice.Width = 95;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.Width = 92;
            // 
            // ImageFile
            // 
            ImageFile.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ImageFile.DataPropertyName = "ImageFile";
            ImageFile.HeaderText = "ImageFile";
            ImageFile.Name = "ImageFile";
            ImageFile.Width = 83;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Resizable = DataGridViewTriState.True;
            Status.SortMode = DataGridViewColumnSortMode.Automatic;
            Status.Width = 64;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.DataPropertyName = "Delete";
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "Xóa ";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 65;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 52;
            // 
            // lblNumOfProduct
            // 
            lblNumOfProduct.AutoSize = true;
            lblNumOfProduct.Location = new Point(101, 99);
            lblNumOfProduct.Name = "lblNumOfProduct";
            lblNumOfProduct.Size = new Size(123, 15);
            lblNumOfProduct.TabIndex = 7;
            lblNumOfProduct.Text = "số lượng sản phầm: 0 ";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(239, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Yellow;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(322, 9);
            label3.Name = "label3";
            label3.Size = new Size(173, 29);
            label3.TabIndex = 9;
            label3.Text = "Quản lý sản phẩm ";
            // 
            // fManageProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(lblNumOfProduct);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(ckCategory);
            Controls.Add(btFind);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(cbCategories);
            Controls.Add(btNew);
            Text = "Quản lý Sản phẩm ";
            WindowState = FormWindowState.Maximized;
            Activated += fManageProduct_Activated;
            Load += fManageProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btNew;
        private ComboBox cbCategories;
        private TextBox txtName;
        private Label label1;
        private Button btFind;
        private CheckBox ckCategory;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn MarketPrice;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn ImageFile;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn Edit;
        private Label lblNumOfProduct;
        private PictureBox pictureBox1;
        private Label label3;
        private ToolTip toolTip1;
    }
}