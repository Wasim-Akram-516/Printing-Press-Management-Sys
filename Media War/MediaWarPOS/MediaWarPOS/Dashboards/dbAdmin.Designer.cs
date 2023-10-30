namespace MediaWarPOS.Dashboards
{
    partial class dbAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.LinkBtnLogOut = new System.Windows.Forms.LinkLabel();
            this.pnlStock = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStockCatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStockCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvProductCatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvProdCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvBrandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvGram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvRetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPerItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvItemsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStockQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDashboardButtons = new System.Windows.Forms.Panel();
            this.btnInvestment = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnSalaries = new System.Windows.Forms.Button();
            this.pnlUser.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlStock.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlDashboardButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.LinkBtnLogOut);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUser.Size = new System.Drawing.Size(832, 55);
            this.pnlUser.Controls.SetChildIndex(this.LinkBtnLogOut, 0);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDetails.Size = new System.Drawing.Size(273, 645);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlDashboardButtons);
            this.pnlMain.Controls.Add(this.pnlStock);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Size = new System.Drawing.Size(832, 645);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnInvestment, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEmployees, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSuppliers, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStock, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnProducts, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCategories, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSales, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSalaries, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 645);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 78);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADMIN\r\nDASHBOARD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LinkBtnLogOut
            // 
            this.LinkBtnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkBtnLogOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.LinkBtnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkBtnLogOut.Location = new System.Drawing.Point(754, 0);
            this.LinkBtnLogOut.Name = "LinkBtnLogOut";
            this.LinkBtnLogOut.Size = new System.Drawing.Size(78, 55);
            this.LinkBtnLogOut.TabIndex = 15;
            this.LinkBtnLogOut.TabStop = true;
            this.LinkBtnLogOut.Text = "Log out";
            this.LinkBtnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LinkBtnLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkBtnLogOut_LinkClicked);
            // 
            // pnlStock
            // 
            this.pnlStock.Controls.Add(this.groupBox2);
            this.pnlStock.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlStock.Location = new System.Drawing.Point(491, 0);
            this.pnlStock.Name = "pnlStock";
            this.pnlStock.Size = new System.Drawing.Size(341, 645);
            this.pnlStock.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 645);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvSNO,
            this.gvStockCatID,
            this.gvStockCatName,
            this.gvProductCatID,
            this.gvProdCatName,
            this.gvBrandID,
            this.gvBrandName,
            this.gvProductID,
            this.gvSize,
            this.gvGram,
            this.gvCostPrice,
            this.gvRetailPrice,
            this.gvPerItemPrice,
            this.gvItemsNo,
            this.gvQTY,
            this.gvDate,
            this.gvStockID,
            this.gvStockQTY});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(335, 620);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // gvSNO
            // 
            this.gvSNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSNO.HeaderText = "Sr.";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            this.gvSNO.Visible = false;
            this.gvSNO.Width = 32;
            // 
            // gvStockCatID
            // 
            this.gvStockCatID.HeaderText = "Stock Cat ID";
            this.gvStockCatID.Name = "gvStockCatID";
            this.gvStockCatID.ReadOnly = true;
            this.gvStockCatID.Visible = false;
            // 
            // gvStockCatName
            // 
            this.gvStockCatName.HeaderText = "Stock Cat";
            this.gvStockCatName.Name = "gvStockCatName";
            this.gvStockCatName.ReadOnly = true;
            this.gvStockCatName.Visible = false;
            // 
            // gvProductCatID
            // 
            this.gvProductCatID.HeaderText = "Product Cat ID";
            this.gvProductCatID.Name = "gvProductCatID";
            this.gvProductCatID.ReadOnly = true;
            this.gvProductCatID.Visible = false;
            // 
            // gvProdCatName
            // 
            this.gvProdCatName.HeaderText = "Product";
            this.gvProdCatName.Name = "gvProdCatName";
            this.gvProdCatName.ReadOnly = true;
            // 
            // gvBrandID
            // 
            this.gvBrandID.HeaderText = "Brand ID";
            this.gvBrandID.Name = "gvBrandID";
            this.gvBrandID.ReadOnly = true;
            this.gvBrandID.Visible = false;
            // 
            // gvBrandName
            // 
            this.gvBrandName.HeaderText = "Brand Name";
            this.gvBrandName.Name = "gvBrandName";
            this.gvBrandName.ReadOnly = true;
            this.gvBrandName.Visible = false;
            // 
            // gvProductID
            // 
            this.gvProductID.HeaderText = "Product ID";
            this.gvProductID.Name = "gvProductID";
            this.gvProductID.ReadOnly = true;
            this.gvProductID.Visible = false;
            // 
            // gvSize
            // 
            this.gvSize.HeaderText = "Size";
            this.gvSize.Name = "gvSize";
            this.gvSize.ReadOnly = true;
            // 
            // gvGram
            // 
            this.gvGram.HeaderText = "Gram";
            this.gvGram.Name = "gvGram";
            this.gvGram.ReadOnly = true;
            // 
            // gvCostPrice
            // 
            this.gvCostPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvCostPrice.HeaderText = "Cost Price";
            this.gvCostPrice.Name = "gvCostPrice";
            this.gvCostPrice.ReadOnly = true;
            this.gvCostPrice.Visible = false;
            this.gvCostPrice.Width = 97;
            // 
            // gvRetailPrice
            // 
            this.gvRetailPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvRetailPrice.HeaderText = "Retail Price";
            this.gvRetailPrice.Name = "gvRetailPrice";
            this.gvRetailPrice.ReadOnly = true;
            this.gvRetailPrice.Visible = false;
            this.gvRetailPrice.Width = 102;
            // 
            // gvPerItemPrice
            // 
            this.gvPerItemPrice.HeaderText = "Per Item Price";
            this.gvPerItemPrice.Name = "gvPerItemPrice";
            this.gvPerItemPrice.ReadOnly = true;
            this.gvPerItemPrice.Visible = false;
            // 
            // gvItemsNo
            // 
            this.gvItemsNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvItemsNo.HeaderText = "Items per Pack";
            this.gvItemsNo.Name = "gvItemsNo";
            this.gvItemsNo.ReadOnly = true;
            this.gvItemsNo.Visible = false;
            this.gvItemsNo.Width = 133;
            // 
            // gvQTY
            // 
            this.gvQTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvQTY.HeaderText = "QTY";
            this.gvQTY.Name = "gvQTY";
            this.gvQTY.ReadOnly = true;
            this.gvQTY.Visible = false;
            this.gvQTY.Width = 64;
            // 
            // gvDate
            // 
            this.gvDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Format = "D";
            this.gvDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvDate.HeaderText = "Date";
            this.gvDate.Name = "gvDate";
            this.gvDate.ReadOnly = true;
            this.gvDate.Visible = false;
            this.gvDate.Width = 64;
            // 
            // gvStockID
            // 
            this.gvStockID.HeaderText = "Stock ID";
            this.gvStockID.Name = "gvStockID";
            this.gvStockID.ReadOnly = true;
            this.gvStockID.Visible = false;
            // 
            // gvStockQTY
            // 
            this.gvStockQTY.HeaderText = "QTY";
            this.gvStockQTY.Name = "gvStockQTY";
            this.gvStockQTY.ReadOnly = true;
            // 
            // pnlDashboardButtons
            // 
            this.pnlDashboardButtons.Controls.Add(this.tableLayoutPanel1);
            this.pnlDashboardButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboardButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboardButtons.Name = "pnlDashboardButtons";
            this.pnlDashboardButtons.Size = new System.Drawing.Size(491, 645);
            this.pnlDashboardButtons.TabIndex = 2;
            // 
            // btnInvestment
            // 
            this.btnInvestment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInvestment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvestment.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvestment.Image = global::MediaWarPOS.Properties.Resources.icons8_investment_96;
            this.btnInvestment.Location = new System.Drawing.Point(3, 3);
            this.btnInvestment.Name = "btnInvestment";
            this.btnInvestment.Size = new System.Drawing.Size(157, 155);
            this.btnInvestment.TabIndex = 5;
            this.btnInvestment.Text = "INVESTMENTS";
            this.btnInvestment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInvestment.UseVisualStyleBackColor = true;
            this.btnInvestment.Click += new System.EventHandler(this.btnInvestment_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Image = global::MediaWarPOS.Properties.Resources.icons8_management_96;
            this.btnEmployees.Location = new System.Drawing.Point(166, 3);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(157, 155);
            this.btnEmployees.TabIndex = 6;
            this.btnEmployees.Text = "EMPLOYEES";
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.Image = global::MediaWarPOS.Properties.Resources.icons8_folded_booklet_96;
            this.btnSuppliers.Location = new System.Drawing.Point(329, 3);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(159, 155);
            this.btnSuppliers.TabIndex = 7;
            this.btnSuppliers.Text = "BRANDS";
            this.btnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click_1);
            // 
            // btnStock
            // 
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Image = global::MediaWarPOS.Properties.Resources.icons8_sell_stock_96;
            this.btnStock.Location = new System.Drawing.Point(329, 164);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(159, 155);
            this.btnStock.TabIndex = 10;
            this.btnStock.Text = "STOCK";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click_1);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Image = global::MediaWarPOS.Properties.Resources.icons8_pages_96;
            this.btnProducts.Location = new System.Drawing.Point(166, 164);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(157, 155);
            this.btnProducts.TabIndex = 9;
            this.btnProducts.Text = "PRODUCTS";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click_1);
            // 
            // btnCategories
            // 
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.Image = global::MediaWarPOS.Properties.Resources.icons8_categories_64;
            this.btnCategories.Location = new System.Drawing.Point(3, 164);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(157, 155);
            this.btnCategories.TabIndex = 8;
            this.btnCategories.Text = "Categories";
            this.btnCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click_1);
            // 
            // btnSales
            // 
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Image = global::MediaWarPOS.Properties.Resources.icons8_sales_96;
            this.btnSales.Location = new System.Drawing.Point(3, 325);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(157, 155);
            this.btnSales.TabIndex = 11;
            this.btnSales.Text = "SALES";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnSalaries
            // 
            this.btnSalaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalaries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaries.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalaries.Image = global::MediaWarPOS.Properties.Resources.icons8_cash_in_hand_96;
            this.btnSalaries.Location = new System.Drawing.Point(166, 325);
            this.btnSalaries.Name = "btnSalaries";
            this.btnSalaries.Size = new System.Drawing.Size(157, 155);
            this.btnSalaries.TabIndex = 12;
            this.btnSalaries.Text = "SALARIES";
            this.btnSalaries.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalaries.UseVisualStyleBackColor = true;
            this.btnSalaries.Click += new System.EventHandler(this.btnSalaries_Click);
            // 
            // dbAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 700);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dbAdmin";
            this.Text = "dbAdmin";
            this.Load += new System.EventHandler(this.dbAdmin_Load);
            this.pnlUser.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlStock.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlDashboardButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInvestment;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.LinkLabel LinkBtnLogOut;
        private System.Windows.Forms.Panel pnlDashboardButtons;
        private System.Windows.Forms.Panel pnlStock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStockCatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStockCatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvProductCatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvProdCatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvBrandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvGram;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvRetailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPerItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvItemsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStockQTY;
        private System.Windows.Forms.Button btnSalaries;
    }
}