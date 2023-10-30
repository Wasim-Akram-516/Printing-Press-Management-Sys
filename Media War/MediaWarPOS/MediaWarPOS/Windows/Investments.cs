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
    public partial class Investments : Settings.WindowSample
    {
        public Investments()
        {
            InitializeComponent();
        }
        int edit = 0, investmentID;
        Regex rgNumber = new Regex("^[.?\\d]+$");
        private void Investments_Load(object sender, EventArgs e)
        {
            Classes.clsMain.DisableReset(pnlDetails);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtName, errName);
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtAmount, errAmount);
            if (txtAmount.Text != "")
            {
                if (!rgNumber.Match(txtAmount.Text).Success)
                {
                    txtAmount.SelectAll();
                    txtAmount.Focus();
                    Classes.clsMain.ShowMsg("Invalid Format!", "Error", "Errror");
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
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            
            Classes.clsMain.ShowErr(txtName, errName);
            Classes.clsMain.ShowErr(txtAmount, errAmount);
            if (errName.Visible || errAmount.Visible)
            {
                Classes.clsMain.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                if (edit == 0)
                {
                    Classes.clsInsert.InsertInvestments(txtName.Text,Convert.ToSingle(txtAmount.Text),dtDate.Value);
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
                else if (edit == 1)
                {
                    Classes.clsUpdate.UpdateInvestments(investmentID,txtName.Text, Convert.ToSingle(txtAmount.Text), dtDate.Value);
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
                    Classes.clsDelete.Delete(investmentID, "stpDeleteInvestments", "@investmentID");
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
            Classes.clsSelect.selectInvestments(dataGridView1,gvInvestmentID,gvName,gvAmount,gvDate);
            Classes.clsMain.SNO(dataGridView1, "gvSNO");
        }
        private void SearchData()
        {
            if (txtSearch.Text != "")
            {
                Classes.clsSelect.selectInvestments(dataGridView1, gvInvestmentID, gvName, gvAmount, gvDate,txtSearch.Text);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                edit = 1;
                Classes.clsMain.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                investmentID = Convert.ToInt32(row.Cells["gvInvestmentID"].Value.ToString());
                txtName.Text = row.Cells["gvName"].Value.ToString();
                txtAmount.Text = row.Cells["gvAmount"].Value.ToString();
                dtDate.Value = Convert.ToDateTime(row.Cells["gvDate"].Value.ToString());
            }
        }

    }
}
