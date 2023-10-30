using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaWarPOS.Windows
{
    public partial class Brands : Settings.WindowSample
    {
        public Brands()
        {
            InitializeComponent();
        }
        int edit = 0, brandID;

        private void Suppliers_Load(object sender, EventArgs e)
        {
            Classes.clsMain.DisableReset(pnlDetails);
        }
        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtBrandName, errSupplier);
        }

        private void txtPhone1_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtPhone1, errPhone1);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtAddress, erraddress);
        }

        private void ddStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            Classes.clsMain.EnableReset(pnlDetails);
            txtBrandName.Focus();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            Classes.clsMain.Enable(pnlDetails);
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtBrandName, errSupplier);
            Classes.clsMain.ShowErr(txtPhone1, errPhone1);
            Classes.clsMain.ShowErr(txtAddress, erraddress);
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }
            if (errSupplier.Visible||errPhone1.Visible||erraddress.Visible||errStatus.Visible)
            {
                Classes.clsMain.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                if (edit == 0)
                {
                    Classes.clsInsert.InsertBrands(txtBrandName.Text,txtPhone1.Text,txtPhone2.Text,txtAddress.Text, Convert.ToInt16(ddStatus.SelectedIndex));
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
                else if (edit == 1)
                {
                    Classes.clsUpdate.UpdateBrands(brandID,txtBrandName.Text, txtPhone1.Text, txtPhone2.Text, txtAddress.Text, Convert.ToInt16(ddStatus.SelectedIndex));
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtBrandName.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Classes.clsDelete.Delete(brandID, "stpDeleteBrands", "@brandID");
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
            Classes.clsSelect.selectBrands(dataGridView1,gvBrandID,gvName,gvPhone1,gvPhone2, gvAddress, gvStatus);
            Classes.clsMain.SNO(dataGridView1, "gvSNO");
        }
        private void SearchData()
        {
            if (txtSearch.Text != "")
            {
                Classes.clsSelect.selectBrands(dataGridView1, gvBrandID, gvName, gvPhone1, gvPhone2, gvAddress, gvStatus,txtSearch.Text);
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

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                edit = 1;
                Classes.clsMain.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                brandID = Convert.ToInt32(row.Cells["gvBrandID"].Value.ToString());
                txtBrandName.Text = row.Cells["gvName"].Value.ToString();
                txtPhone1.Text = row.Cells["gvPhone1"].Value.ToString();
                txtPhone2.Text = row.Cells["gvPhone2"].Value.ToString();
                txtAddress.Text = row.Cells["gvAddress"].Value.ToString();
                ddStatus.Text = row.Cells["gvStatus"].Value.ToString();
            }
        }
        
    }
}
