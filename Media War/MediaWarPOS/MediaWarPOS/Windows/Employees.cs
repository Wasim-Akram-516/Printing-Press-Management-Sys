using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaWarPOS.Windows
{
    public partial class Employees : Settings.WindowSample
    {
        public Employees()
        {
            InitializeComponent();
        }
        int edit = 0,employeeID;
        Regex rgMail = new Regex("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");
        Regex rgPhone = new Regex("^[0-9]*$");
        Regex rgNumber = new Regex("^[.?\\d]+$");
        Regex rgCNIC = new Regex("^(\\d{5}-\\d{7}-\\d)$");
        private void Employees_Load(object sender, EventArgs e)
        {
            Classes.clsMain.DisableReset(pnlDetails);
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtName, errName);
        }

        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtCNIC, errCNIC);
        }

        private void txtPhone1_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtPhone1, errPhone1);
        }

        private void txtPhone2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalery_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtSalery, errSalery);
            if (txtSalery.Text != "")
            {
                if (!rgNumber.Match(txtSalery.Text).Success)
                {
                    txtSalery.SelectAll();
                    txtSalery.Focus();
                    Classes.clsMain.ShowMsg("Invalid Format!", "Error", "Errror");
                }
            }
        }
       
        private void ddStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            Classes.clsMain.EnableReset(pnlDetails);
            txtName.Focus();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            Classes.clsMain.Enable(pnlDetails);
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtName, errName);
            Classes.clsMain.ShowErr(txtCNIC, errCNIC);
            Classes.clsMain.ShowErr(txtPhone1, errPhone1);
            Classes.clsMain.ShowErr(txtSalery, errSalery);
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }
            if (errName.Visible || errCNIC.Visible || errPhone1.Visible || errSalery.Visible || errStatus.Visible)
            {
                Classes.clsMain.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                if (edit==0)
                {
                    Classes.clsInsert.InsertEmployees(txtName.Text, txtCNIC.Text, txtPhone1.Text, txtPhone2.Text, Convert.ToSingle(txtSalery.Text), Convert.ToInt16(ddStatus.SelectedIndex), dtJoinDate.Value, dtLeftDate.Value);
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
                else if (edit==1)
                {
                    Classes.clsUpdate.UpdateEmployees(employeeID,txtName.Text, txtCNIC.Text, txtPhone1.Text, txtPhone2.Text, Convert.ToSingle(txtSalery.Text), Convert.ToInt16(ddStatus.SelectedIndex), dtJoinDate.Value, dtLeftDate.Value);
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtName.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Classes.clsDelete.Delete(employeeID, "stpDeleteEmployees", "@employeeID");
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            Classes.clsSelect.selectEmployees(dataGridView1, gvEmployeeID, gvName, gvCNIC, gvPhone1, gvPhone2, gvSalery, gvStatus, gvJoiningDate, gvLeftDate);
            Classes.clsMain.SNO(dataGridView1, "gvSNO");
        }
        private void SearchData()
        {
            if (txtSearch.Text != "")
            {
                Classes.clsSelect.selectEmployees(dataGridView1, gvEmployeeID, gvName, gvCNIC, gvPhone1, gvPhone2, gvSalery, gvStatus, gvJoiningDate, gvLeftDate, txtSearch.Text);
                Classes.clsMain.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                LoadData();
            }
        }
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void txtSalery_Validating(object sender, CancelEventArgs e)
        {
            if (txtSalery.Text != "")
            {
                if (!rgNumber.Match(txtSalery.Text).Success)
                {
                    txtSalery.SelectAll();
                    txtSalery.Focus();
                    Classes.clsMain.ShowMsg("Invalid Format!", "Error", "Errror");
                }
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                edit = 1;
                Classes.clsMain.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                employeeID =Convert.ToInt32( row.Cells["gvEmployeeID"].Value.ToString());
                txtName.Text = row.Cells["gvName"].Value.ToString();
                txtCNIC.Text= row.Cells["gvCNIC"].Value.ToString();
                txtPhone1.Text= row.Cells["gvPhone1"].Value.ToString();
                txtPhone2.Text= row.Cells["gvPhone2"].Value.ToString();
                txtSalery.Text= row.Cells["gvSalery"].Value.ToString();
                ddStatus.Text= row.Cells["gvStatus"].Value.ToString();
                dtJoinDate.Value=Convert.ToDateTime( row.Cells["gvJoiningDate"].Value.ToString());
                dtLeftDate.Value = Convert.ToDateTime(row.Cells["gvLeftDate"].Value.ToString());
            }
        }
    }
}
