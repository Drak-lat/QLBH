namespace QLBH
{
    partial class fProcessOrderDetails
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
            cbOrders = new ComboBox();
            btClose = new Button();
            toolTip1 = new ToolTip(components);
            txtProgressName = new TextBox();
            txtCustomerName = new TextBox();
            txtEmployeeName = new TextBox();
            txtOrderDate = new TextBox();
            txtReceiveDate = new TextBox();
            txtOrderTime = new TextBox();
            txtReceiveTime = new TextBox();
            dataGridView1 = new DataGridView();
            OrderDetailID = new DataGridViewTextBoxColumn();
            OrderID = new DataGridViewTextBoxColumn();
            ProductID = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            cbProducts = new ComboBox();
            mQuantity = new MaskedTextBox();
            mPrice = new MaskedTextBox();
            btClear = new Button();
            btAddOrderDetail = new Button();
            btSaveOrderDetail = new Button();
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
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbOrders
            // 
            cbOrders.FormattingEnabled = true;
            cbOrders.Location = new Point(2, 168);
            cbOrders.Margin = new Padding(6, 4, 6, 4);
            cbOrders.Name = "cbOrders";
            cbOrders.Size = new Size(262, 35);
            cbOrders.TabIndex = 0;
            cbOrders.SelectionChangeCommitted += cbOrders_SelectionChangeCommitted;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Red;
            btClose.Location = new Point(1247, 266);
            btClose.Margin = new Padding(6, 4, 6, 4);
            btClose.Name = "btClose";
            btClose.Size = new Size(166, 39);
            btClose.TabIndex = 1;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // txtProgressName
            // 
            txtProgressName.Enabled = false;
            txtProgressName.Location = new Point(296, 168);
            txtProgressName.Margin = new Padding(6, 4, 6, 4);
            txtProgressName.Name = "txtProgressName";
            txtProgressName.Size = new Size(215, 34);
            txtProgressName.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Enabled = false;
            txtCustomerName.Location = new Point(414, 269);
            txtCustomerName.Margin = new Padding(6, 4, 6, 4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(215, 34);
            txtCustomerName.TabIndex = 3;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Enabled = false;
            txtEmployeeName.Location = new Point(898, 269);
            txtEmployeeName.Margin = new Padding(6, 4, 6, 4);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(215, 34);
            txtEmployeeName.TabIndex = 4;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Enabled = false;
            txtOrderDate.Location = new Point(561, 168);
            txtOrderDate.Margin = new Padding(6, 4, 6, 4);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(228, 34);
            txtOrderDate.TabIndex = 5;
            // 
            // txtReceiveDate
            // 
            txtReceiveDate.Enabled = false;
            txtReceiveDate.Location = new Point(1106, 168);
            txtReceiveDate.Margin = new Padding(6, 4, 6, 4);
            txtReceiveDate.Name = "txtReceiveDate";
            txtReceiveDate.Size = new Size(258, 34);
            txtReceiveDate.TabIndex = 6;
            // 
            // txtOrderTime
            // 
            txtOrderTime.Enabled = false;
            txtOrderTime.Location = new Point(824, 168);
            txtOrderTime.Margin = new Padding(6, 4, 6, 4);
            txtOrderTime.Name = "txtOrderTime";
            txtOrderTime.Size = new Size(208, 34);
            txtOrderTime.TabIndex = 7;
            // 
            // txtReceiveTime
            // 
            txtReceiveTime.Enabled = false;
            txtReceiveTime.Location = new Point(1448, 168);
            txtReceiveTime.Margin = new Padding(6, 4, 6, 4);
            txtReceiveTime.Name = "txtReceiveTime";
            txtReceiveTime.Size = new Size(277, 34);
            txtReceiveTime.TabIndex = 8;
            txtReceiveTime.TextChanged += txtReceiveTime_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderDetailID, OrderID, ProductID, Quantity, Price, Amount, Delete });
            dataGridView1.Location = new Point(225, 483);
            dataGridView1.Margin = new Padding(6, 4, 6, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1024, 253);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // OrderDetailID
            // 
            OrderDetailID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderDetailID.DataPropertyName = "OrderDetailID";
            OrderDetailID.HeaderText = "OrderDetailID";
            OrderDetailID.MinimumWidth = 6;
            OrderDetailID.Name = "OrderDetailID";
            OrderDetailID.ReadOnly = true;
            OrderDetailID.Width = 196;
            // 
            // OrderID
            // 
            OrderID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderID.DataPropertyName = "OrderID";
            OrderID.HeaderText = "OrderID";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            OrderID.Width = 131;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductID.DataPropertyName = "ProductID";
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            ProductID.Width = 154;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 135;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 128;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.DataPropertyName = "Delete";
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 114;
            // 
            // cbProducts
            // 
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(225, 413);
            cbProducts.Margin = new Padding(6, 4, 6, 4);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(262, 35);
            cbProducts.TabIndex = 1;
            cbProducts.SelectedIndexChanged += cbProducts_SelectedIndexChanged;
            // 
            // mQuantity
            // 
            mQuantity.Location = new Point(519, 413);
            mQuantity.Margin = new Padding(6, 4, 6, 4);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(215, 34);
            mQuantity.TabIndex = 2;
            // 
            // mPrice
            // 
            mPrice.Location = new Point(784, 413);
            mPrice.Margin = new Padding(6, 4, 6, 4);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(215, 34);
            mPrice.TabIndex = 3;
            // 
            // btClear
            // 
            btClear.BackColor = Color.IndianRed;
            btClear.Location = new Point(1056, 411);
            btClear.Margin = new Padding(6, 4, 6, 4);
            btClear.Name = "btClear";
            btClear.Size = new Size(166, 39);
            btClear.TabIndex = 5;
            btClear.Text = "Xóa Ô";
            btClear.UseVisualStyleBackColor = false;
            btClear.Click += btClear_Click;
            // 
            // btAddOrderDetail
            // 
            btAddOrderDetail.BackColor = Color.Fuchsia;
            btAddOrderDetail.ForeColor = SystemColors.ActiveCaptionText;
            btAddOrderDetail.Location = new Point(1247, 413);
            btAddOrderDetail.Margin = new Padding(6, 4, 6, 4);
            btAddOrderDetail.Name = "btAddOrderDetail";
            btAddOrderDetail.Size = new Size(166, 39);
            btAddOrderDetail.TabIndex = 4;
            btAddOrderDetail.Text = "Thêm mới";
            btAddOrderDetail.UseVisualStyleBackColor = false;
            btAddOrderDetail.Click += btAddOrderDetail_Click;
            // 
            // btSaveOrderDetail
            // 
            btSaveOrderDetail.BackColor = Color.FromArgb(255, 255, 192);
            btSaveOrderDetail.Location = new Point(1448, 411);
            btSaveOrderDetail.Margin = new Padding(6, 4, 6, 4);
            btSaveOrderDetail.Name = "btSaveOrderDetail";
            btSaveOrderDetail.Size = new Size(166, 39);
            btSaveOrderDetail.TabIndex = 6;
            btSaveOrderDetail.Text = "Lưu sửa";
            btSaveOrderDetail.UseVisualStyleBackColor = false;
            btSaveOrderDetail.Click += btSaveOrderDetail_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 126);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 27);
            label1.TabIndex = 9;
            label1.Text = "Chọn đơn hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 126);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 27);
            label2.TabIndex = 10;
            label2.Text = "Tiến Trình";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(834, 138);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 27);
            label3.TabIndex = 11;
            label3.Text = "Giờ:Phút:Giây";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(561, 138);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(190, 27);
            label4.TabIndex = 12;
            label4.Text = "Ngày/tháng/năm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(743, 99);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 32);
            label5.TabIndex = 13;
            label5.Text = "Đặt Hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1463, 126);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(157, 27);
            label6.TabIndex = 14;
            label6.Text = "Giờ:phút:giây";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1133, 138);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(190, 27);
            label7.TabIndex = 15;
            label7.Text = "Ngày/tháng/năm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(1336, 99);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(129, 27);
            label8.TabIndex = 16;
            label8.Text = "Giao Hàng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(225, 273);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(150, 27);
            label9.TabIndex = 17;
            label9.Text = "Khách Hàng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(736, 269);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(127, 27);
            label10.TabIndex = 18;
            label10.Text = "Nhân Viên";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(239, 370);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(186, 27);
            label11.TabIndex = 19;
            label11.Text = "Chọn Sản Phẩm ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(544, 370);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(114, 27);
            label12.TabIndex = 20;
            label12.Text = "Số Lượng ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(824, 370);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(95, 27);
            label13.TabIndex = 21;
            label13.Text = "Đơn Giá";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Berlin Sans FB Demi", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Blue;
            label14.Location = new Point(635, 10);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(424, 45);
            label14.TabIndex = 22;
            label14.Text = "Xử lý chi tiết đơn hàng";
            // 
            // fProcessOrderDetails
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1778, 804);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
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
            Controls.Add(btSaveOrderDetail);
            Controls.Add(btAddOrderDetail);
            Controls.Add(btClear);
            Controls.Add(mPrice);
            Controls.Add(mQuantity);
            Controls.Add(cbProducts);
            Controls.Add(dataGridView1);
            Controls.Add(txtReceiveTime);
            Controls.Add(txtOrderTime);
            Controls.Add(txtReceiveDate);
            Controls.Add(txtOrderDate);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtCustomerName);
            Controls.Add(txtProgressName);
            Controls.Add(btClose);
            Controls.Add(cbOrders);
            Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 4, 6, 4);
            Name = "fProcessOrderDetails";
            Text = "Xử lý chi tiết đơn hàng";
            WindowState = FormWindowState.Maximized;
            Load += fProcessOrderDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbOrders;
        private Button btClose;
        private ToolTip toolTip1;
        private TextBox txtProgressName;
        private TextBox txtCustomerName;
        private TextBox txtEmployeeName;
        private TextBox txtOrderDate;
        private TextBox txtReceiveDate;
        private TextBox txtOrderTime;
        private TextBox txtReceiveTime;
        private DataGridView dataGridView1;
        private ComboBox cbProducts;
        private MaskedTextBox mQuantity;
        private MaskedTextBox mPrice;
        private Button btClear;
        private Button btAddOrderDetail;
        private Button btSaveOrderDetail;
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
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridViewTextBoxColumn OrderDetailID;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewButtonColumn Delete;
        private Label label14;
    }
}