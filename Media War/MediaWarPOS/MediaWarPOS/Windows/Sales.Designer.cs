namespace MediaWarPOS.Windows
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.gvPerItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.pnlDetails.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(131, 26);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.lblTotalSales);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.btnLoad);
            this.pnlDetails.Controls.Add(this.dtEnd);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.dtStart);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Size = new System.Drawing.Size(273, 654);
            this.pnlDetails.Controls.SetChildIndex(this.label4, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtStart, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtEnd, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnLoad, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label3, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblTotalSales, 0);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Size = new System.Drawing.Size(833, 654);
            this.pnlMain.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 588);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.gvPerItemPrice,
            this.gvSaleID,
            this.gvQTY,
            this.gvPrice,
            this.gvPurpose,
            this.gvDate});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(827, 563);
            this.dataGridView1.TabIndex = 0;
            // 
            // gvSNO
            // 
            this.gvSNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSNO.HeaderText = "Sr.";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            this.gvSNO.Width = 51;
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
            this.gvProdCatName.HeaderText = "Product Cat";
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
            // gvPerItemPrice
            // 
            this.gvPerItemPrice.HeaderText = "Per Item Price";
            this.gvPerItemPrice.Name = "gvPerItemPrice";
            this.gvPerItemPrice.ReadOnly = true;
            // 
            // gvSaleID
            // 
            this.gvSaleID.HeaderText = "Sale ID";
            this.gvSaleID.Name = "gvSaleID";
            this.gvSaleID.ReadOnly = true;
            this.gvSaleID.Visible = false;
            // 
            // gvQTY
            // 
            this.gvQTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvQTY.HeaderText = "QTY";
            this.gvQTY.Name = "gvQTY";
            this.gvQTY.ReadOnly = true;
            this.gvQTY.Width = 64;
            // 
            // gvPrice
            // 
            this.gvPrice.HeaderText = "Price";
            this.gvPrice.Name = "gvPrice";
            this.gvPrice.ReadOnly = true;
            // 
            // gvPurpose
            // 
            this.gvPurpose.HeaderText = "Purpose";
            this.gvPurpose.Name = "gvPurpose";
            this.gvPurpose.ReadOnly = true;
            // 
            // gvDate
            // 
            dataGridViewCellStyle2.Format = "M";
            dataGridViewCellStyle2.NullValue = null;
            this.gvDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvDate.HeaderText = "Date";
            this.gvDate.Name = "gvDate";
            this.gvDate.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 78;
            this.label4.Text = "From";
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(8, 88);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(259, 26);
            this.dtStart.TabIndex = 0;
            this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(8, 138);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(259, 26);
            this.dtEnd.TabIndex = 1;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 80;
            this.label2.Text = "To";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(8, 170);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(259, 40);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 83;
            this.label3.Text = "Total: Rs.";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(117, 213);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(0, 25);
            this.lblTotalSales.TabIndex = 84;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 701);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPerItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSaleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPurpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDate;
    }
}