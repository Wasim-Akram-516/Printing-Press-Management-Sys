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
    public partial class WorkDetails : Settings.WindowSample
    {
        public WorkDetails()
        {
            InitializeComponent();
        }
        Regex rgPhone = new Regex("^[0-9]*$");
        Regex rgNumber = new Regex("^[.?\\d]+$");
        int edit = 0, workDetailID;
        decimal total, paid, remaining;

        private void calculateRemaining()
        {
            decimal.TryParse(txtTotal.Text, out total);
            decimal.TryParse(txtPaid.Text, out paid);

            remaining = total - paid;
            txtRemaining.Text = remaining.ToString();
        }

        private void loadList()
        {
            Classes.clsMain.GetDropdownList("stpSelectCustomerDetails", ddCustomer, "name", "customerID");
        }

        public override void btnBack_Click(object sender, EventArgs e)
        {
            Dashboards.dbCustomers obj = new Dashboards.dbCustomers();
            Classes.clsMain.ShowWindow(obj, this, Settings.MDI.ActiveForm);
        }

        private void WorkDetails_Load(object sender, EventArgs e)
        {
            loadList();
            Classes.clsMain.DisableReset(pnlDetails);
        }
       
        private void ddCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddCustomer.SelectedIndex <= 0) { errCustomer.Visible = true; }else { errCustomer.Visible = false; }
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

        private void ddIsDelivered_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddIsDelivered.SelectedIndex < 0) { errDelivered.Visible = true; } else { errDelivered.Visible = false; }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            Classes.clsMain.EnableReset(pnlDetails);
            txtRemaining.Enabled = false;
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            Classes.clsMain.Enable(pnlDetails);
            txtRemaining.Enabled = false;
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (errCustomer.Visible||errWorkDetails.Visible || errTotal.Visible || errPaid.Visible || errRemaining.Visible||errDelivered.Visible)
            {
                Classes.clsMain.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {

                if (edit == 0)
                {
                    Classes.clsInsert.AddWorkDetails(Convert.ToInt32(ddCustomer.SelectedValue), dtDate.Value, txtWorkDetails.Text, total, paid, remaining, Convert.ToBoolean(ddIsDelivered.SelectedIndex));
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
                else if (edit == 1)
                {
                    Classes.clsUpdate.UpdateWorkDetails(workDetailID,Convert.ToInt32(ddCustomer.SelectedValue), dtDate.Value, txtWorkDetails.Text, total, paid, remaining, Convert.ToBoolean(ddIsDelivered.SelectedIndex));
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtWorkDetails.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Classes.clsDelete.Delete(workDetailID, "stpDeleteWorkDetails", "@workDetailID");
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (txtSearch.Text == "")
            {
                Classes.clsSelect.selectWorkDetails(dataGridView1, gvWorkDetailID, gvCustomerID,gvName, gvDate, gvWorkDetails, gvTotal, gvPaid, gvRemeining, gvDelivered);
                Classes.clsMain.SNO(dataGridView1, "gvSNO");
            }
            else
            {
                Classes.clsSelect.selectWorkDetails(dataGridView1, gvWorkDetailID, gvCustomerID, gvName, gvDate, gvWorkDetails, gvTotal, gvPaid, gvRemeining, gvDelivered,txtSearch.Text);
                Classes.clsMain.SNO(dataGridView1, "gvSNO");
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                edit = 1;
                Classes.clsMain.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                workDetailID = Convert.ToInt32(row.Cells["gvWorkDetailID"].Value.ToString());
                ddCustomer.SelectedValue = Convert.ToInt32(row.Cells["gvCustomerID"].Value.ToString());
                txtWorkDetails.Text = row.Cells["gvWorkDetails"].Value.ToString();
                dtDate.Value = Convert.ToDateTime(row.Cells["gvDate"].Value.ToString());
                txtTotal.Text = row.Cells["gvTotal"].Value.ToString();
                txtPaid.Text = row.Cells["gvPaid"].Value.ToString();
                txtRemaining.Text = row.Cells["gvRemeining"].Value.ToString();
                ddIsDelivered.Text= row.Cells["gvDelivered"].Value.ToString();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

    }
}
