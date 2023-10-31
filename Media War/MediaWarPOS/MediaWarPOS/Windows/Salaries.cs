using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaWarPOS.Windows
{
    public partial class Salaries : Settings.WindowSample
    {
        public Salaries()
        {
            InitializeComponent();
        }
        int edit = 0;
        Regex rgNumber = new Regex("^[.?\\d]+$");
        float salary, paid, total;
        private bool isDataGridViewLoading = false;
        Int64 salaryID;

        private void Salaries_Load(object sender, EventArgs e)
        {
            Classes.clsMain.DisableReset(pnlDetails);
            txtSalary.Enabled = false;
            txtTotalPaid.Enabled = false;
            LoadList();
            LoadData();
        }
        private void LoadData()
        {
            Classes.clsSelect.selectSalaries(dataGridView1, gvEmployeeID, gvName, gvSalary, gvSalaryID, gvMonth, gvYear, gvDate, gvPaidAmount, gvTotalPaid, gvPaymentType, gvRemarks, dtMonth.Value.Month, dtMonth.Value.Year);
            Classes.clsMain.SNO(dataGridView1, "gvSNO");
        }

        private void LoadList()
        {
            Classes.clsMain.GetDropdownList("stpSelectEmployeesActive", ddEmployee, "name", "employeeID");
        }

        private void LoadTotalPaid()
        {
            Classes.clsSelect.selectTotalPaidSalaryForEmployee(txtSalary,txtTotalPaid, Convert.ToInt32(ddEmployee.SelectedValue), dtMonth.Value.Month, dtMonth.Value.Year);
        }
        private void PaidLimitCheck()
        {
            if (isDataGridViewLoading)
                return;

            salary = Convert.ToSingle(txtSalary.Text);
            paid = Convert.ToSingle(txtPaidAmount.Text);
            total = Convert.ToSingle(txtTotalPaid.Text);

            if ((paid + total) > salary && edit!=1)
            {
                Classes.clsMain.ShowMsg("Limit Exceeded", "Error", "");
                txtPaidAmount.Focus();
                txtPaidAmount.SelectAll();
            }
        }

        private void ddEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddEmployee.SelectedIndex <= 0) { errEmployee.Visible = true; } else { errEmployee.Visible = false; }
            if (ddEmployee.SelectedIndex > 0)
            {
                LoadTotalPaid();
            }
            else
            {
                txtTotalPaid.Text = "";
            }
        }

        private void ddPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddPaymentType.SelectedIndex < 0) { errPaymentType.Visible = true; } else { errPaymentType.Visible = false; }
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalPaid.Text != "" && txtSalary.Text != "" && txtPaidAmount.Text != "")
            {
                PaidLimitCheck();
            }

        }

        private void txtTotalPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalPaid.Text != "" && txtSalary.Text!=""&& txtPaidAmount.Text!="")
            {
                PaidLimitCheck();
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtPaidAmount, errPaidAmount);
            if (txtPaidAmount.Text != "")
            {
                if (!rgNumber.Match(txtPaidAmount.Text).Success)
                {
                    txtPaidAmount.SelectAll();
                    txtPaidAmount.Focus();
                    Classes.clsMain.ShowMsg("Invalid Format!", "Error", "Errror");
                }
                else
                {
                    PaidLimitCheck();
                }
            }
        }
        
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            Classes.clsMain.EnableReset(pnlDetails);
            txtSalary.Enabled = false;
            txtTotalPaid.Enabled = false;
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            Classes.clsMain.Enable(pnlDetails);
            txtSalary.Enabled = false;
            txtTotalPaid.Enabled = false;
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (errEmployee.Visible||errPaymentType.Visible||errPaidAmount.Visible)
            {
                Classes.clsMain.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                if (edit==0)
                {
                    Classes.clsInsert.InsertSalaries(Convert.ToInt32(ddEmployee.SelectedValue), dtMonth.Value.Month,dtMonth.Value.Year,dtPaymentDate.Value,Convert.ToSingle(txtPaidAmount.Text),Convert.ToByte( ddPaymentType.SelectedIndex),txtRemarks.Text);
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
                else if (edit==1)
                {
                    Classes.clsUpdate.UpdateSalaries(salaryID,Convert.ToInt32(ddEmployee.SelectedValue), dtMonth.Value.Month, dtMonth.Value.Year, dtPaymentDate.Value, Convert.ToSingle(txtPaidAmount.Text), Convert.ToByte(ddPaymentType.SelectedIndex), txtRemarks.Text);
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this salary?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Classes.clsDelete.Delete(salaryID, "stpDeleteSalaries", "@salaryID");
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        

        private void dtMonth_ValueChanged(object sender, EventArgs e)
        {
            if (ddEmployee.SelectedIndex>0)
            {
                LoadTotalPaid();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                isDataGridViewLoading = true;
                edit = 1;
                Classes.clsMain.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                salaryID = Convert.ToInt64(row.Cells["gvSalaryID"].Value.ToString());
                ddEmployee.SelectedValue = Convert.ToInt32(row.Cells["gvEmployeeID"].Value.ToString());
                dtPaymentDate.Value = Convert.ToDateTime(row.Cells["gvDate"].Value.ToString());
                ddPaymentType.Text = row.Cells["gvPaymentType"].Value.ToString();
                txtSalary.Text = row.Cells["gvSalary"].Value.ToString();
                txtTotalPaid.Text = row.Cells["gvTotalPaid"].Value.ToString();
                txtPaidAmount.Text = row.Cells["gvPaidAmount"].Value.ToString();
                txtRemarks.Text = row.Cells["gvRemarks"].Value.ToString();
                isDataGridViewLoading = false;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Formatting month names
            if (dataGridView1.Columns[e.ColumnIndex].Name == "gvMonth" && e.Value != null)
            {
                try
                {
                    int monthNumber = Convert.ToInt32(e.Value);
                    e.Value = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthNumber);
                    e.FormattingApplied = true;
                }
                catch (Exception x)
                {
                    Classes.clsMain.ShowMsg(x.Message, "Error", "Error");
                }
            }

            // Highlighting cells based on conditions for "Total Paid" and "Salary"
            if (dataGridView1.Columns[e.ColumnIndex].Name == "gvTotalPaid" && e.RowIndex >= 0)
            {
                try
                {
                    float totalPaid = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells["gvTotalPaid"].Value);
                    float salary = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells["gvSalary"].Value);

                    if (totalPaid == salary)
                    {
                        e.CellStyle.BackColor = Color.Red; // If Total Paid is equal to Salary, set cell background to Red
                    }
                    else if ((salary - totalPaid) <= 2000)
                    {
                        e.CellStyle.BackColor = Color.Yellow; // If the difference between Salary and Total Paid is 1000, set cell background to Yellow
                    }
                }
                catch (Exception x)
                {
                    Classes.clsMain.ShowMsg(x.Message, "Error", "Error");
                }
            }
        }


        private void SearchData()
        {
            if (txtSearch.Text != "")
            {
                
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

    }
}
