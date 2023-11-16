namespace MediaWarPOS.Windows
{
    partial class Salaries
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
            this.dtMonth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSalaryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvTotalPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.ddEmployee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.ddPaymentType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errEmployee = new System.Windows.Forms.Label();
            this.errPaymentType = new System.Windows.Forms.Label();
            this.errPaidAmount = new System.Windows.Forms.Label();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlDetails.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(160, 26);
            // 
            // pnlUser
            // 
            this.pnlUser.Size = new System.Drawing.Size(1017, 47);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.txtSalary);
            this.pnlDetails.Controls.Add(this.label8);
            this.pnlDetails.Controls.Add(this.txtTotalPaid);
            this.pnlDetails.Controls.Add(this.label10);
            this.pnlDetails.Controls.Add(this.errPaidAmount);
            this.pnlDetails.Controls.Add(this.errPaymentType);
            this.pnlDetails.Controls.Add(this.errEmployee);
            this.pnlDetails.Controls.Add(this.txtRemarks);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.ddPaymentType);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.dtPaymentDate);
            this.pnlDetails.Controls.Add(this.txtPaidAmount);
            this.pnlDetails.Controls.Add(this.ddEmployee);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.dtMonth);
            this.pnlDetails.Size = new System.Drawing.Size(273, 720);
            this.pnlDetails.Controls.SetChildIndex(this.dtMonth, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label3, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label4, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddEmployee, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtPaidAmount, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtPaymentDate, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label5, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label6, 0);
            this.pnlDetails.Controls.SetChildIndex(this.ddPaymentType, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label7, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtRemarks, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errEmployee, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errPaymentType, 0);
            this.pnlDetails.Controls.SetChildIndex(this.errPaidAmount, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label10, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtTotalPaid, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label8, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtSalary, 0);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Size = new System.Drawing.Size(1017, 720);
            this.pnlMain.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // dtMonth
            // 
            this.dtMonth.CustomFormat = "MMMM - yyyy";
            this.dtMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMonth.Location = new System.Drawing.Point(6, 88);
            this.dtMonth.Name = "dtMonth";
            this.dtMonth.ShowUpDown = true;
            this.dtMonth.Size = new System.Drawing.Size(259, 26);
            this.dtMonth.TabIndex = 0;
            this.dtMonth.ValueChanged += new System.EventHandler(this.dtMonth_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Month";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1017, 654);
            this.groupBox2.TabIndex = 4;
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
            this.gvEmployeeID,
            this.gvName,
            this.gvSalary,
            this.gvSalaryID,
            this.gvMonth,
            this.gvYear,
            this.gvPaidAmount,
            this.gvDate,
            this.gvPaymentType,
            this.gvRemarks,
            this.gvTotalPaid});
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
            this.dataGridView1.Size = new System.Drawing.Size(1011, 629);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // gvSNO
            // 
            this.gvSNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSNO.HeaderText = "Sr.No.";
            this.gvSNO.Name = "gvSNO";
            this.gvSNO.ReadOnly = true;
            this.gvSNO.Width = 74;
            // 
            // gvEmployeeID
            // 
            this.gvEmployeeID.HeaderText = "Employee ID";
            this.gvEmployeeID.Name = "gvEmployeeID";
            this.gvEmployeeID.ReadOnly = true;
            this.gvEmployeeID.Visible = false;
            // 
            // gvName
            // 
            this.gvName.HeaderText = "Name";
            this.gvName.Name = "gvName";
            this.gvName.ReadOnly = true;
            // 
            // gvSalary
            // 
            this.gvSalary.HeaderText = "Salary";
            this.gvSalary.Name = "gvSalary";
            this.gvSalary.ReadOnly = true;
            // 
            // gvSalaryID
            // 
            this.gvSalaryID.HeaderText = "Salary ID";
            this.gvSalaryID.Name = "gvSalaryID";
            this.gvSalaryID.ReadOnly = true;
            this.gvSalaryID.Visible = false;
            // 
            // gvMonth
            // 
            this.gvMonth.HeaderText = "Month";
            this.gvMonth.Name = "gvMonth";
            this.gvMonth.ReadOnly = true;
            // 
            // gvYear
            // 
            this.gvYear.HeaderText = "Year";
            this.gvYear.Name = "gvYear";
            this.gvYear.ReadOnly = true;
            this.gvYear.Visible = false;
            // 
            // gvPaidAmount
            // 
            this.gvPaidAmount.HeaderText = "Paid Amount";
            this.gvPaidAmount.Name = "gvPaidAmount";
            this.gvPaidAmount.ReadOnly = true;
            // 
            // gvDate
            // 
            dataGridViewCellStyle2.Format = "M";
            dataGridViewCellStyle2.NullValue = null;
            this.gvDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvDate.HeaderText = "Payment Date";
            this.gvDate.Name = "gvDate";
            this.gvDate.ReadOnly = true;
            // 
            // gvPaymentType
            // 
            this.gvPaymentType.HeaderText = "Payment Type";
            this.gvPaymentType.Name = "gvPaymentType";
            this.gvPaymentType.ReadOnly = true;
            // 
            // gvRemarks
            // 
            this.gvRemarks.HeaderText = "Remarks";
            this.gvRemarks.Name = "gvRemarks";
            this.gvRemarks.ReadOnly = true;
            // 
            // gvTotalPaid
            // 
            this.gvTotalPaid.HeaderText = "Total Paid";
            this.gvTotalPaid.Name = "gvTotalPaid";
            this.gvTotalPaid.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee Name";
            // 
            // ddEmployee
            // 
            this.ddEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddEmployee.FormattingEnabled = true;
            this.ddEmployee.Location = new System.Drawing.Point(8, 138);
            this.ddEmployee.Name = "ddEmployee";
            this.ddEmployee.Size = new System.Drawing.Size(259, 26);
            this.ddEmployee.TabIndex = 1;
            this.ddEmployee.SelectedIndexChanged += new System.EventHandler(this.ddEmployee_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Paid Amount";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(8, 387);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(259, 26);
            this.txtPaidAmount.TabIndex = 6;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Payment Date";
            // 
            // dtPaymentDate
            // 
            this.dtPaymentDate.CustomFormat = "";
            this.dtPaymentDate.Location = new System.Drawing.Point(8, 187);
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.Size = new System.Drawing.Size(259, 26);
            this.dtPaymentDate.TabIndex = 2;
            // 
            // ddPaymentType
            // 
            this.ddPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddPaymentType.FormattingEnabled = true;
            this.ddPaymentType.Items.AddRange(new object[] {
            "Advance",
            "Partial",
            "Monthly"});
            this.ddPaymentType.Location = new System.Drawing.Point(8, 237);
            this.ddPaymentType.Name = "ddPaymentType";
            this.ddPaymentType.Size = new System.Drawing.Size(259, 26);
            this.ddPaymentType.TabIndex = 3;
            this.ddPaymentType.SelectedIndexChanged += new System.EventHandler(this.ddPaymentType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Payment Type";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(8, 436);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(259, 26);
            this.txtRemarks.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Remarks";
            // 
            // errEmployee
            // 
            this.errEmployee.AutoSize = true;
            this.errEmployee.Location = new System.Drawing.Point(250, 117);
            this.errEmployee.Name = "errEmployee";
            this.errEmployee.Size = new System.Drawing.Size(16, 18);
            this.errEmployee.TabIndex = 14;
            this.errEmployee.Text = "*";
            // 
            // errPaymentType
            // 
            this.errPaymentType.AutoSize = true;
            this.errPaymentType.Location = new System.Drawing.Point(249, 216);
            this.errPaymentType.Name = "errPaymentType";
            this.errPaymentType.Size = new System.Drawing.Size(16, 18);
            this.errPaymentType.TabIndex = 15;
            this.errPaymentType.Text = "*";
            // 
            // errPaidAmount
            // 
            this.errPaidAmount.AutoSize = true;
            this.errPaidAmount.Location = new System.Drawing.Point(249, 366);
            this.errPaidAmount.Name = "errPaidAmount";
            this.errPaidAmount.Size = new System.Drawing.Size(16, 18);
            this.errPaidAmount.TabIndex = 16;
            this.errPaidAmount.Text = "*";
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Location = new System.Drawing.Point(8, 337);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.Size = new System.Drawing.Size(259, 26);
            this.txtTotalPaid.TabIndex = 5;
            this.txtTotalPaid.TextChanged += new System.EventHandler(this.txtTotalPaid_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Total Paid";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(8, 287);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(259, 26);
            this.txtSalary.TabIndex = 4;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Salary";
            // 
            // Salaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 767);
            this.Name = "Salaries";
            this.Text = "Salaries";
            this.Load += new System.EventHandler(this.Salaries_Load);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtMonth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ddEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtPaymentDate;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddPaymentType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label errEmployee;
        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label errPaidAmount;
        private System.Windows.Forms.Label errPaymentType;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSalaryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvTotalPaid;
    }
}