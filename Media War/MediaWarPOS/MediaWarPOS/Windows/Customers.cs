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
    public partial class Customers : Settings.WindowSample
    {
        public Customers()
        {
            InitializeComponent();
        }
        Regex rgPhone = new Regex("^[0-9]*$");
        Regex rgNumber = new Regex("^[.?\\d]+$");
        int edit = 0, customerID;
        decimal total, paid, remaining;
        private void Customers_Load(object sender, EventArgs e)
        {
            Classes.clsMain.DisableReset(pnlDetails);
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

        private void txtWorkDetails_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtWorkDetails, errWorkDetails);
        }
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtTotal, errTotal);
            if (txtTotal.Text != "")
            {
                if (!rgNumber.Match(txtTotal.Text).Success)
                {
                    txtTotal.Clear();
                    txtTotal.Focus();
                }
                else
                {
                    calculateRemaining();
                }
            }
            
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtPaid, errPaid);
            if (txtPaid.Text != "")
            {
                if (!rgNumber.Match(txtPaid.Text).Success)
                {
                    txtPaid.Clear();
                    txtPaid.Focus();
                }
                else
                {
                    calculateRemaining();
                }
            }
        }

        private void txtRemaining_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void calculateRemaining()
        {
            decimal.TryParse(txtTotal.Text, out total);
            decimal.TryParse(txtPaid.Text, out paid);

            remaining = total - paid;
            txtRemaining.Text = remaining.ToString();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            Classes.clsMain.EnableReset(pnlDetails);
            txtName.Focus();
            txtRemaining.Enabled = false;
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            Classes.clsMain.Enable(pnlDetails);
            txtName.Focus();
            txtRemaining.Enabled = false;
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (errName.Visible || errPhone1.Visible || errWorkDetails.Visible || errTotal.Visible || errPaid.Visible || errRemaining.Visible)
            {
                Classes.clsMain.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {

                if (edit == 0)
                {
                    Classes.clsInsert.InsertCustomers(txtName.Text, txtPhone1.Text, txtPhone2.Text,dtDate.Value,txtWorkDetails.Text,total,paid,remaining);
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
                else if (edit == 1)
                {
                    Classes.clsUpdate.UpdateCustomers(customerID,txtName.Text, txtPhone1.Text, txtPhone2.Text, dtDate.Value, txtWorkDetails.Text, total, paid, remaining);
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
                    Classes.clsDelete.Delete(customerID, "stpDeleteCustomers", "@customerID");
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
                Classes.clsSelect.selectCustomers(dataGridView1,gvCustomerID,gvName,gvPhone1,gvPhone2,gvDate,gvWorkDetails,gvTotal,gvPaid,gvRemeining);
                Classes.clsMain.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                Classes.clsSelect.selectCustomers(dataGridView1, gvCustomerID, gvName, gvPhone1, gvPhone2, gvDate, gvWorkDetails,gvTotal, gvPaid, gvRemeining, txtSearch.Text);
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
                txtWorkDetails.Text = row.Cells["gvWorkDetails"].Value.ToString();
                dtDate.Value = Convert.ToDateTime(row.Cells["gvDate"].Value.ToString());
                txtTotal.Text = row.Cells["gvTotal"].Value.ToString();
                txtPaid.Text = row.Cells["gvPaid"].Value.ToString();
                txtRemaining.Text = row.Cells["gvRemeining"].Value.ToString();
            }
        }
        
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
