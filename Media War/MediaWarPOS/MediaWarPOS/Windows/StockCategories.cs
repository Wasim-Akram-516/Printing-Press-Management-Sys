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
    public partial class StockCategories : Settings.WindowSample
    {
        public StockCategories()
        {
            InitializeComponent();
        }
        int edit = 0, stockCatID;
        private void txtStockCatName_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtStockCatName, errStockCatName);
        }

        private void ddStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }
        }
        public override void btnBack_Click(object sender, EventArgs e)
        {
            Categories obj = new Categories();
            Classes.clsMain.ShowWindow(obj, this, Settings.MDI.ActiveForm);
        }
        
        private void StockCategories_Load(object sender, EventArgs e)
        {
            Classes.clsMain.DisableReset(pnlDetails);
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            Classes.clsMain.EnableReset(pnlDetails);
            txtStockCatName.Focus();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            Classes.clsMain.Enable(pnlDetails);
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtStockCatName, errStockCatName);
            if (ddStatus.SelectedIndex == -1) { errStatus.Visible = true; } else { errStatus.Visible = false; }
            if (errStockCatName.Visible || errStatus.Visible)
            {
                Classes.clsMain.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                if (edit == 0)
                {
                    Classes.clsInsert.InsertStockCategories(txtStockCatName.Text, Convert.ToInt16(ddStatus.SelectedIndex));
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
                else if (edit == 1)
                {
                    Classes.clsUpdate.UpdateStockCategories(stockCatID, txtStockCatName.Text, Convert.ToInt16(ddStatus.SelectedIndex));
                    LoadData();
                    Classes.clsMain.DisableReset(pnlDetails);
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txtStockCatName.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Classes.clsDelete.Delete(stockCatID, "stpDeleteStockCategories", "@stockCatID");
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
            Classes.clsSelect.selectStockCategories(dataGridView1, gvStockCatID, gvName, gvStatus);
            Classes.clsMain.SNO(dataGridView1, "gvSNO");
        }
        private void SearchData()
        {
            if (txtSearch.Text != "")
            {
                Classes.clsSelect.selectStockCategories(dataGridView1, gvStockCatID, gvName, gvStatus, txtSearch.Text);
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

        private void ProductCategories_Load(object sender, EventArgs e)
        {
            Classes.clsMain.DisableReset(pnlDetails);
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                edit = 1;
                Classes.clsMain.Disable(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                stockCatID = Convert.ToInt32(row.Cells["gvStockCatID"].Value.ToString());
                txtStockCatName.Text = row.Cells["gvName"].Value.ToString();
                ddStatus.Text = row.Cells["gvStatus"].Value.ToString();
            }
        }
    }
}
