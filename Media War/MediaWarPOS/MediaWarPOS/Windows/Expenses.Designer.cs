namespace MediaWarPOS.Windows
{
    partial class Expenses
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtReceiptName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReceiptNo = new System.Windows.Forms.TextBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.errDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.errAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.errDescription = new System.Windows.Forms.Label();
            this.ddExpenseType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errExpenseType = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvExpenseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvReceiptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvReceiptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvRemove = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.txtReceiptName);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.txtReceiptNo);
            this.pnlDetails.Controls.Add(this.btnAddToList);
            this.pnlDetails.Controls.Add(this.dtDate);
            this.pnlDetails.Controls.Add(this.label9);
            this.pnlDetails.Controls.Add(this.errDate);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.txtAmount);
            this.pnlDetails.Controls.Add(this.errAmount);
            this.pnlDetails.Controls.Add(this.label8);
            this.pnlDetails.Controls.Add(this.txtDescription);
            this.pnlDetails.Controls.Add(this.errDescription);
            this.pnlDetails.Controls.Add(this.ddExpenseType);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.errExpenseType);
            this.pnlDetails.Size = new System.Drawing.Size(273, 654);
            this.pnlDetails.Controls.SetChildIndex(this.errExpenseType, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label6, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddExpenseType, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errDescription, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtDescription, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label8, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errAmount, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtAmount, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label3, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errDate, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label9, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtDate, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnAddToList, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtReceiptNo, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label5, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtReceiptName, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label2, 0);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Size = new System.Drawing.Size(833, 654);
            this.pnlMain.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 99;
            this.label2.Text = "Receipt Name";
            // 
            // txtReceiptName
            // 
            this.txtReceiptName.Location = new System.Drawing.Point(3, 304);
            this.txtReceiptName.Name = "txtReceiptName";
            this.txtReceiptName.Size = new System.Drawing.Size(263, 26);
            this.txtReceiptName.TabIndex = 4;
            this.txtReceiptName.TextChanged += new System.EventHandler(this.txtReceiptName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 98;
            this.label5.Text = "Receipt #";
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Location = new System.Drawing.Point(3, 355);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Size = new System.Drawing.Size(263, 26);
            this.txtReceiptNo.TabIndex = 5;
            this.txtReceiptNo.TextChanged += new System.EventHandler(this.txtReceiptNo_TextChanged);
            // 
            // btnAddToList
            // 
            this.btnAddToList.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddToList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToList.Location = new System.Drawing.Point(4, 386);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(263, 40);
            this.btnAddToList.TabIndex = 6;
            this.btnAddToList.Text = " ADD TO LIST";
            this.btnAddToList.UseVisualStyleBackColor = false;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "dddd , dd-MMMM-yyyy";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(3, 88);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(263, 26);
            this.dtDate.TabIndex = 0;
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 18);
            this.label9.TabIndex = 96;
            this.label9.Text = "Date";
            // 
            // errDate
            // 
            this.errDate.AutoSize = true;
            this.errDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDate.Location = new System.Drawing.Point(245, 65);
            this.errDate.Name = "errDate";
            this.errDate.Size = new System.Drawing.Size(20, 28);
            this.errDate.TabIndex = 97;
            this.errDate.Text = "*";
            this.errDate.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 94;
            this.label3.Text = "Amount (Rs.)";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(4, 254);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(263, 26);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // errAmount
            // 
            this.errAmount.AutoSize = true;
            this.errAmount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errAmount.Location = new System.Drawing.Point(246, 232);
            this.errAmount.Name = "errAmount";
            this.errAmount.Size = new System.Drawing.Size(20, 28);
            this.errAmount.TabIndex = 95;
            this.errAmount.Text = "*";
            this.errAmount.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 92;
            this.label8.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(3, 184);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(263, 45);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // errDescription
            // 
            this.errDescription.AutoSize = true;
            this.errDescription.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDescription.Location = new System.Drawing.Point(245, 162);
            this.errDescription.Name = "errDescription";
            this.errDescription.Size = new System.Drawing.Size(20, 28);
            this.errDescription.TabIndex = 93;
            this.errDescription.Text = "*";
            this.errDescription.Visible = false;
            // 
            // ddExpenseType
            // 
            this.ddExpenseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddExpenseType.FormattingEnabled = true;
            this.ddExpenseType.Items.AddRange(new object[] {
            "Miscellaneous",
            "Advertisement",
            "Cleaning Materials",
            "Daily Utilities",
            "Maintenance",
            "Purchasing",
            "Rent",
            "Refreshment",
            "Stationery",
            "Utility Bills",
            "Welfare"});
            this.ddExpenseType.Location = new System.Drawing.Point(4, 135);
            this.ddExpenseType.Name = "ddExpenseType";
            this.ddExpenseType.Size = new System.Drawing.Size(263, 26);
            this.ddExpenseType.TabIndex = 1;
            this.ddExpenseType.SelectedIndexChanged += new System.EventHandler(this.ddExpenseType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 90;
            this.label6.Text = "Expense Type";
            // 
            // errExpenseType
            // 
            this.errExpenseType.AutoSize = true;
            this.errExpenseType.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errExpenseType.Location = new System.Drawing.Point(246, 114);
            this.errExpenseType.Name = "errExpenseType";
            this.errExpenseType.Size = new System.Drawing.Size(20, 28);
            this.errExpenseType.TabIndex = 91;
            this.errExpenseType.Text = "*";
            this.errExpenseType.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 588);
            this.groupBox2.TabIndex = 11;
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
            this.gvDate,
            this.gvExpenseType,
            this.gvDescription,
            this.gvAmount,
            this.gvReceiptName,
            this.gvReceiptNo,
            this.gvRemove});
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
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gvSNO
            // 
            this.gvSNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSNO.HeaderText = "Sr.";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            this.gvSNO.Width = 51;
            // 
            // gvDate
            // 
            dataGridViewCellStyle2.Format = "M";
            dataGridViewCellStyle2.NullValue = null;
            this.gvDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvDate.HeaderText = "Date";
            this.gvDate.Name = "gvDate";
            this.gvDate.ReadOnly = true;
            this.gvDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gvExpenseType
            // 
            this.gvExpenseType.HeaderText = "Expense Type";
            this.gvExpenseType.Name = "gvExpenseType";
            this.gvExpenseType.ReadOnly = true;
            // 
            // gvDescription
            // 
            this.gvDescription.HeaderText = "Description";
            this.gvDescription.Name = "gvDescription";
            this.gvDescription.ReadOnly = true;
            // 
            // gvAmount
            // 
            this.gvAmount.HeaderText = "Amount";
            this.gvAmount.Name = "gvAmount";
            this.gvAmount.ReadOnly = true;
            // 
            // gvReceiptName
            // 
            this.gvReceiptName.HeaderText = "Receipt Name";
            this.gvReceiptName.Name = "gvReceiptName";
            this.gvReceiptName.ReadOnly = true;
            // 
            // gvReceiptNo
            // 
            this.gvReceiptNo.HeaderText = "Receipt #";
            this.gvReceiptNo.Name = "gvReceiptNo";
            this.gvReceiptNo.ReadOnly = true;
            // 
            // gvRemove
            // 
            this.gvRemove.HeaderText = "Action";
            this.gvRemove.Name = "gvRemove";
            this.gvRemove.ReadOnly = true;
            this.gvRemove.Text = "Remove";
            this.gvRemove.UseColumnTextForButtonValue = true;
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 701);
            this.Name = "Expenses";
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.Expenses_Load);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReceiptName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReceiptNo;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label errDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label errAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label errDescription;
        private System.Windows.Forms.ComboBox ddExpenseType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label errExpenseType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvExpenseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvReceiptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvReceiptNo;
        private System.Windows.Forms.DataGridViewButtonColumn gvRemove;
    }
}