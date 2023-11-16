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
    public partial class CustomerDetails : Settings.WindowSample
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }
        Regex rgPhone = new Regex("^[0-9]*$");
        Regex rgNumber = new Regex("^[.?\\d]+$");
        int edit = 0, customerID;

        private void Customers_Load(object sender, EventArgs e)
        {
            Classes.clsMain.DisableReset(pnlDetails);
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            Dashboards.dbCustomers obj = new Dashboards.dbCustomers();
            Classes.clsMain.ShowWindow(obj, this, Settings.MDI.ActiveForm);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtName, errName);
        }

        private void txtPhone1_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtPhone1, errPhone1);
            if (txtPhone1.Text != "")
            {
                if (!rgPhone.Match(txtPhone1.Text).Success)
                {
                    txtPhone1.Clear();
                    txtPhone1.Focus();
                }
            }
        }

        private void txtPhone2_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone2.Text != "")
            {
                if (!rgPhone.Match(txtPhone2.Text).Success)
                {
                    txtPhone2.Clear();
                    txtPhone2.Focus();
                }
            }
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
            txtName.Focus();
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (errName.Visible || errPhone1.Visible)
            {
                Classes.clsMain.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {

                if (edit == 0)
                {
                    Classes.clsInsert.InsertCustomerDetails(txtName.Text, txtPhone1.Text, txtPhone2.Text);
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
                else if (edit == 1)
                {
                    Classes.clsUpdate.UpdateCustomerDetails(customerID,txtName.Text, txtPhone1.Text, txtPhone2.Text);
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
                    Classes.clsDelete.Delete(customerID, "stpDeleteCustomerDetails", "@customerID");
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
            if (txtSearch.Text=="")
            {
                Classes.clsSelect.selectCustomerDetails(dataGridView1,gvCustomerID,gvName,gvPhone1,gvPhone2);
                Classes.clsMain.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                Classes.clsSelect.selectCustomerDetails(dataGridView1, gvCustomerID, gvName, gvPhone1, gvPhone2, txtSearch.Text);
                Classes.clsMain.SNO(dataGridView1, "gvSNO");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                edit = 1;
                Classes.clsMain.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                customerID = Convert.ToInt32(row.Cells["gvCustomerID"].Value.ToString());
                txtName.Text = row.Cells["gvName"].Value.ToString();
                txtPhone1.Text = row.Cells["gvPhone1"].Value.ToString();
                txtPhone2.Text = row.Cells["gvPhone2"].Value.ToString();
            }
        }
        
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
