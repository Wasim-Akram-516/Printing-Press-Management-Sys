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
    public partial class Expenses : Settings.WindowSample
    {
        public Expenses()
        {
            InitializeComponent();
        }
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        private int check;
        private void Expenses_Load(object sender, EventArgs e)
        {
            Classes.clsMain.DisableReset(pnlDetails);
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtDate.Value.Date > DateTime.Now.Date) { errDate.Visible = true; } else { errDate.Visible = false; }
        }

        private void ddExpenseType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text == "") { errAmount.Visible = true; }
            else
            {
                errAmount.Visible = false;

                if (!rg.Match(txtAmount.Text).Success)
                {
                    txtAmount.Focus();
                    txtAmount.Text = "";
                }
            }
        }

        private void txtReceiptName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReceiptNo_TextChanged(object sender, EventArgs e)
        {
            if (txtReceiptNo.Text != "")
            {
                if (!rg.Match(txtReceiptNo.Text).Success)
                {
                    txtReceiptNo.Focus();
                    txtReceiptNo.Text = "";
                }
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (dtDate.Value.Date > DateTime.Now.Date) { errDate.Visible = true; } else { errDate.Visible = false; }
            if (ddExpenseType.SelectedIndex == -1) { errExpenseType.Visible = true; } else { errExpenseType.Visible = false; }
            if (txtDescription.Text == "") { errDescription.Visible = true; } else { errDescription.Visible = false; }
            if (txtAmount.Text == "") { errAmount.Visible = true; } else { errAmount.Visible = false; }
            if (errDate.Visible)
            {
                Classes.clsMain.ShowMsg("Invalid Date!", "Error", "Error");
            }

            if (errExpenseType.Visible || errDescription.Visible || errAmount.Visible)
            {
                Classes.clsMain.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }

            else
            {
                dataGridView1.Rows.Add(1,dtDate.Value, ddExpenseType.Text, txtDescription.Text, txtAmount.Text, txtReceiptName.Text, txtReceiptNo.Text);
                Classes.clsMain.SNO(dataGridView1, "gvSNO");
                ddExpenseType.SelectedIndex = -1;
                txtDescription.Text = "";
                txtAmount.Text = "";
                txtReceiptName.Text = "";
                txtReceiptNo.Text = "";
                ddExpenseType.Focus();
            }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            Classes.clsMain.EnableReset(pnlDetails);
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (dtDate.Value.Date > DateTime.Now.Date) { errDate.Visible = true; } else { errDate.Visible = false; }

            if (errDate.Visible)
            {
                Classes.clsMain.ShowMsg("Invalid Date!", "Error", "Error");
            }

            else
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        check = Classes.clsInsert.AddExpenses(Convert.ToDateTime(row.Cells["gvDate"].Value), row.Cells["gvExpenseType"].Value.ToString(), 
                            row.Cells["gvDescription"].Value.ToString(), Convert.ToSingle(row.Cells["gvAmount"].Value), row.Cells["gvReceiptName"].Value.ToString(), row.Cells["gvReceiptNo"].Value.ToString());
                    }

                    if (check > 0)
                    {
                        Classes.clsMain.ShowMsg(dataGridView1.Rows.Count + " Expense Details added successfully!", "Success", "Success");
                        dataGridView1.Rows.Clear();
                        Classes.clsMain.DisableReset(pnlDetails);
                    }

                    else
                    {
                        Classes.clsMain.ShowMsg("Unable to add.\nContact your system administrator for more details.", "Error", "Error");
                    }
                }
                else
                {
                    Classes.clsMain.ShowMsg("PLease, enter at least 1 expenditure detail to continue..", "Error", "Error");
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            Classes.clsMain.ShowMsg("Press View Button and then load records to delete any details.", "Information", "Success");
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            ExpensesView obj = new Windows.ExpensesView();
            Classes.clsMain.ShowWindow(obj, this,Settings.MDI.ActiveForm);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowMsg("Press View Button and then load records to search any details.", "Information", "Success");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int ck = e.ColumnIndex;
                if (e.ColumnIndex == 7)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    dataGridView1.Rows.Remove(row);
                    Classes.clsMain.SNO(dataGridView1, "gvSNO");
                }
            }
        }
    }
}
