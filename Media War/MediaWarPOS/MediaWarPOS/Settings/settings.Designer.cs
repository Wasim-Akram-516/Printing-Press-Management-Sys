namespace MediaWarPOS.Settings
{
    partial class settings
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.errPassword = new System.Windows.Forms.Label();
            this.errUsername = new System.Windows.Forms.Label();
            this.errDatabase = new System.Windows.Forms.Label();
            this.errDataSource = new System.Windows.Forms.Label();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUser
            // 
            this.pnlUser.Size = new System.Drawing.Size(794, 55);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.checkBox1);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.txtPassword);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.txtUsername);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.txtDatabase);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.btnSave);
            this.pnlDetails.Controls.Add(this.txtDataSource);
            this.pnlDetails.Controls.Add(this.errPassword);
            this.pnlDetails.Controls.Add(this.errUsername);
            this.pnlDetails.Controls.Add(this.errDatabase);
            this.pnlDetails.Controls.Add(this.errDataSource);
            this.pnlDetails.Size = new System.Drawing.Size(273, 568);
            // 
            // pnlMain
            // 
            this.pnlMain.Size = new System.Drawing.Size(794, 568);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 388);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 22);
            this.checkBox1.TabIndex = 42;
            this.checkBox1.Text = "Integrated Security";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 47;
            this.label6.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 354);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(242, 26);
            this.txtPassword.TabIndex = 41;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 303);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(242, 26);
            this.txtUsername.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Database Name";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(12, 251);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(242, 26);
            this.txtDatabase.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Server Name";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(12, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(242, 51);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtDataSource
            // 
            this.txtDataSource.Location = new System.Drawing.Point(12, 200);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(242, 26);
            this.txtDataSource.TabIndex = 38;
            // 
            // errPassword
            // 
            this.errPassword.AutoSize = true;
            this.errPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPassword.Location = new System.Drawing.Point(234, 334);
            this.errPassword.Name = "errPassword";
            this.errPassword.Size = new System.Drawing.Size(20, 28);
            this.errPassword.TabIndex = 51;
            this.errPassword.Text = "*";
            this.errPassword.Visible = false;
            // 
            // errUsername
            // 
            this.errUsername.AutoSize = true;
            this.errUsername.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errUsername.Location = new System.Drawing.Point(234, 283);
            this.errUsername.Name = "errUsername";
            this.errUsername.Size = new System.Drawing.Size(20, 28);
            this.errUsername.TabIndex = 50;
            this.errUsername.Text = "*";
            this.errUsername.Visible = false;
            // 
            // errDatabase
            // 
            this.errDatabase.AutoSize = true;
            this.errDatabase.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDatabase.Location = new System.Drawing.Point(234, 231);
            this.errDatabase.Name = "errDatabase";
            this.errDatabase.Size = new System.Drawing.Size(20, 28);
            this.errDatabase.TabIndex = 49;
            this.errDatabase.Text = "*";
            this.errDatabase.Visible = false;
            // 
            // errDataSource
            // 
            this.errDataSource.AutoSize = true;
            this.errDataSource.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDataSource.Location = new System.Drawing.Point(234, 180);
            this.errDataSource.Name = "errDataSource";
            this.errDataSource.Size = new System.Drawing.Size(20, 28);
            this.errDataSource.TabIndex = 48;
            this.errDataSource.Text = "*";
            this.errDataSource.Visible = false;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "settings";
            this.Text = "Settings";
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.Label errPassword;
        private System.Windows.Forms.Label errUsername;
        private System.Windows.Forms.Label errDatabase;
        private System.Windows.Forms.Label errDataSource;
    }
}