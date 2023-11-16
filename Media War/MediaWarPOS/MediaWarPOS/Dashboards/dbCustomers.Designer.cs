namespace MediaWarPOS.Dashboards
{
    partial class dbCustomers
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
            this.btnCustomerDetails = new System.Windows.Forms.Button();
            this.btnWorkdetails = new System.Windows.Forms.Button();
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
            // pnlDetails
            // 
            this.pnlDetails.Size = new System.Drawing.Size(273, 577);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tableLayoutPanel1);
            this.pnlMain.Size = new System.Drawing.Size(727, 577);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnCustomerDetails, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnWorkdetails, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(727, 577);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerDetails.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetails.Image = global::MediaWarPOS.Properties.Resources.icons8_management_961;
            this.btnCustomerDetails.Location = new System.Drawing.Point(3, 3);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.Size = new System.Drawing.Size(175, 186);
            this.btnCustomerDetails.TabIndex = 15;
            this.btnCustomerDetails.Text = "CUSTOMER DETAILS";
            this.btnCustomerDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCustomerDetails.UseVisualStyleBackColor = true;
            this.btnCustomerDetails.Click += new System.EventHandler(this.btnCustomerDetails_Click);
            // 
            // btnWorkdetails
            // 
            this.btnWorkdetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWorkdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkdetails.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkdetails.Image = global::MediaWarPOS.Properties.Resources.icons8_edit_property_96;
            this.btnWorkdetails.Location = new System.Drawing.Point(184, 3);
            this.btnWorkdetails.Name = "btnWorkdetails";
            this.btnWorkdetails.Size = new System.Drawing.Size(175, 186);
            this.btnWorkdetails.TabIndex = 16;
            this.btnWorkdetails.Text = "WORK DETAILS";
            this.btnWorkdetails.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnWorkdetails.UseVisualStyleBackColor = true;
            this.btnWorkdetails.Click += new System.EventHandler(this.btnWorkdetails_Click);
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
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dbCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 632);
            this.Name = "dbCustomers";
            this.Text = "Customers";
            this.pnlWelcome.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCustomerDetails;
        private System.Windows.Forms.Button btnWorkdetails;
        private System.Windows.Forms.Button btnBack;
    }
}