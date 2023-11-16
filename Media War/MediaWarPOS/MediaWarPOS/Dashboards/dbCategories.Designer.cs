namespace MediaWarPOS.Windows
{
    partial class Categories
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStockCategories = new System.Windows.Forms.Button();
            this.btnProductCategories = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlWelcome.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.Controls.Add(this.btnBack);
            this.pnlWelcome.Controls.SetChildIndex(this.btnBack, 0);
            // 
            // pnlUser
            // 
            this.pnlUser.Size = new System.Drawing.Size(860, 55);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Size = new System.Drawing.Size(273, 656);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tableLayoutPanel1);
            this.pnlMain.Size = new System.Drawing.Size(860, 656);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnStockCategories, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnProductCategories, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 656);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnStockCategories
            // 
            this.btnStockCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStockCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockCategories.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockCategories.Image = global::MediaWarPOS.Properties.Resources.icons8_sell_stock_96;
            this.btnStockCategories.Location = new System.Drawing.Point(3, 3);
            this.btnStockCategories.Name = "btnStockCategories";
            this.btnStockCategories.Size = new System.Drawing.Size(209, 212);
            this.btnStockCategories.TabIndex = 3;
            this.btnStockCategories.Text = "Stock Categories";
            this.btnStockCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStockCategories.UseVisualStyleBackColor = true;
            this.btnStockCategories.Click += new System.EventHandler(this.btnStockCategories_Click);
            // 
            // btnProductCategories
            // 
            this.btnProductCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProductCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductCategories.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductCategories.Image = global::MediaWarPOS.Properties.Resources.icons8_pages_96;
            this.btnProductCategories.Location = new System.Drawing.Point(218, 3);
            this.btnProductCategories.Name = "btnProductCategories";
            this.btnProductCategories.Size = new System.Drawing.Size(209, 212);
            this.btnProductCategories.TabIndex = 2;
            this.btnProductCategories.Text = "Product Categories";
            this.btnProductCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProductCategories.UseVisualStyleBackColor = true;
            this.btnProductCategories.Click += new System.EventHandler(this.btnProductCategories_Click);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::MediaWarPOS.Properties.Resources.back_wite;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 55);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 711);
            this.Name = "Categories";
            this.Text = "Categories";
            this.pnlWelcome.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnStockCategories;
        private System.Windows.Forms.Button btnProductCategories;
        private System.Windows.Forms.Button btnBack;
    }
}