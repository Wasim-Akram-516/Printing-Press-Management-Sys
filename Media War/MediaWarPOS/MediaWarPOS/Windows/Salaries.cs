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
    public partial class Salaries : Settings.WindowSample
    {
        public Salaries()
        {
            InitializeComponent();
        }
        int edit = 0;
        Regex rgNumber = new Regex("^[.?\\d]+$");
        float salary, paid, total;

        private void Salaries_Load(object sender, EventArgs e)
        {
            Classes.clsMain.DisableReset(pnlDetails);
            txtSalary.Enabled = false;
            txtTotalPaid.Enabled = false;
        }

        private void ddEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddEmployee.SelectedIndex <= 0) { errEmployee.Visible = true; } else { errEmployee.Visible = false; }
        }

        private void ddPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddPaymentType.SelectedIndex < 0) { errPaymentType.Visible = true; } else { errPaymentType.Visible = false; }
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            if (txtSalary.Text != "")
            {
                salary = Convert.ToSingle(txtSalary.Text);
                paid = Convert.ToSingle(txtPaidAmount.Text);
                total = Convert.ToSingle(txtTotalPaid.Text);
                if ((paid + total) > salary)
                {
                    Classes.clsMain.ShowMsg("Limit Exceeded", "Error", "");
                }
            }

        }

        private void txtTotalPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalPaid.Text != "")
            {
                salary = Convert.ToSingle(txtSalary.Text);
                paid = Convert.ToSingle(txtPaidAmount.Text);
                total = Convert.ToSingle(txtTotalPaid.Text);
                if ((paid + total) > salary)
                {
                    Classes.clsMain.ShowMsg("Limit Exceeded", "Error", "");
                }
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
                    salary = Convert.ToSingle(txtSalary.Text);
                    paid = Convert.ToSingle(txtPaidAmount.Text);
                    total = Convert.ToSingle(txtTotalPaid.Text);
                    if ((paid + total) > salary)
                    {
                        Classes.clsMain.ShowMsg("Limit Exceeded", "Error", "");
                    }
                }
            }
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            txtSalary.Enabled = false;
            txtTotalPaid.Enabled = false;
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            txtSalary.Enabled = false;
            txtTotalPaid.Enabled = false;
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            
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
