using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaWarPOS.Settings
{
    public partial class settings : DashboardSample
    {
        public settings()
        {
            InitializeComponent();
        }
        
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (checkBox1.Checked)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                if (txtDataSource.Text == "") { errDataSource.Visible = true; } else { errDataSource.Visible = false; }
                if (txtDatabase.Text == "") { errDatabase.Visible = true; } else { errDatabase.Visible = false; }
                if (errDataSource.Visible || errDatabase.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory!");
                }
                else
                {
                    sb.Append("Data Source=" + txtDataSource.Text + ";Initial Catalog=" + txtDatabase.Text + ";Integrated Security=true;MultipleActiveResultSets=true");
                    File.WriteAllText(Classes.clsMain.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Dashboards.Login log = new Dashboards.Login();
                        Classes.clsMain.ShowWindow(log, this, MDI.ActiveForm);
                    }
                }
            }
            else
            {
                if (txtDataSource.Text == "") { errDataSource.Visible = true; } else { errDataSource.Visible = false; }
                if (txtDatabase.Text == "") { errDatabase.Visible = true; } else { errDatabase.Visible = false; }
                if (txtUsername.Text == "") { errUsername.Visible = true; } else { errUsername.Visible = false; }
                if (txtPassword.Text == "") { errPassword.Visible = true; } else { errPassword.Visible = false; }
                if (errDataSource.Visible || errDatabase.Visible || errUsername.Visible || errPassword.Visible)
                {
                    Classes.clsMain.ShowMsg("Fields with * are mandatory!", "Error", "Error");
                }
                else
                {
                    sb.Append("Data Source=" + txtDataSource.Text + ";Initial Catalog=" + txtDatabase.Text + ";User ID=" + txtUsername.Text + ";Password=" + txtPassword.Text + ";MultipleActiveResultSets=true");
                    File.WriteAllText(Classes.clsMain.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Dashboards.Login log = new Dashboards.Login();
                        Classes.clsMain.ShowWindow(log, this, MDI.ActiveForm);
                    }
                }
            }
        }
    }
}
