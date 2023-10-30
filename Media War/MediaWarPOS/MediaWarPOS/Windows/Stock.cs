using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace MediaWarPOS.Windows
{
    public partial class Stock : Settings.WindowSample
    {
        public Stock()
        {
            InitializeComponent();
        }
        Regex rgNumber = new Regex("^[.?\\d]+$");
        int edit = 0;
        Int64 stockID;
        private void Stock_Load(object sender, EventArgs e)
        {
            Classes.clsMain.DisableReset(pnlDetails);
            btnLoadStock.Enabled = true;
        }

        private void btnLoadStock_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtStockCatName_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtStockCatName, errStockCatName);
        }
        private void txtUseQTY_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtUseQTY, errUseQTY);
            if (txtUseQTY.Text != "")
            {
                if (!rgNumber.Match(txtUseQTY.Text).Success)
                {
                    txtUseQTY.SelectAll();
                    txtUseQTY.Focus();
                    Classes.clsMain.ShowMsg("Invalid Format!", "Error", "Errror");
                }
            }
        }

        private void txtPurpose_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtPurpose, errPurpose);
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            btnLoadStock.Enabled = true;
            txtUseQTY.Enabled = true;
            txtPurpose.Enabled = true;
            txtUseQTY.Focus();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtUseQTY, errUseQTY);
            Classes.clsMain.ShowErr(txtPurpose, errPurpose);
            Classes.clsMain.ShowErr(txtStockCatName, errStockCatName);
            if (errUseQTY.Visible || errPurpose.Visible||errStockCatName.Visible)
            {
                Classes.clsMain.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                if (edit == 0)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        try
                        {
                            int stock, usedQTY, remainQTY;
                            stock = Convert.ToInt32(txtStockQTY.Text);
                            usedQTY = Convert.ToInt32(txtUseQTY.Text);
                            remainQTY = Convert.ToInt32(txtStockQTY.Text) - Convert.ToInt32(txtUseQTY.Text);
                            if (usedQTY > stock)
                            {
                                Classes.clsMain.ShowMsg("Out of Stock!", "Error", "");
                                txtUseQTY.Focus();
                            }
                            else
                            {
                                float price = Convert.ToInt32(txtUseQTY.Text) * Convert.ToSingle(txtPerItemPrice.Text);
                                int chk = Classes.clsInsert.InsertSales(stockID, Convert.ToInt32(txtUseQTY.Text), Convert.ToSingle(txtPerItemPrice.Text), txtPurpose.Text, DateTime.Now.Date, price);

                                if (chk > 0)
                                {
                                    int check = Classes.clsUpdate.UpdateStock(stockID, remainQTY);

                                    if (check > 0)
                                    {
                                        Classes.clsMain.ShowMsg("Stock updated Successfully!", "Success", "Success");
                                        LoadData();
                                        Classes.clsMain.DisableReset(pnlDetails);
                                    }
                                }
                            }
                        }
                        catch (Exception x)
                        {
                            Classes.clsMain.ShowMsg(x.Message, "Error", "Error");
                        }
                        sc.Complete();
                    }
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            Classes.clsSelect.selectStock(dataGridView1, gvStockCatID, gvStockCatName,gvProductCatID,gvProdCatName,gvBrandID,gvBrandName,gvProductID,
                gvSize,gvGram,gvCostPrice,gvRetailPrice,gvPerItemPrice,gvItemsNo,gvQTY,gvDate,gvStockID,gvStockQTY);
            Classes.clsMain.SNO(dataGridView1, "gvSNO");
        }
        private void SearchData()
        {
            if (txtSearch.Text != "")
            {
                Classes.clsSelect.selectStock(dataGridView1, gvStockCatID, gvStockCatName, gvProductCatID, gvProdCatName, gvBrandID, gvBrandName, gvProductID,
                gvSize, gvGram, gvCostPrice, gvRetailPrice, gvPerItemPrice, gvItemsNo, gvQTY, gvDate, gvStockID, gvStockQTY,txtSearch.Text);
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
                Classes.clsMain.DisableReset(pnlDetails);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                stockID = Convert.ToInt32(row.Cells["gvStockID"].Value.ToString());
                txtStockCatName.Text = row.Cells["gvStockCatName"].Value.ToString();
                txtProductCatName.Text = row.Cells["gvProdCatName"].Value.ToString();
                txtBrandName.Text = row.Cells["gvBrandName"].Value.ToString();
                txtSize.Text = row.Cells["gvSize"].Value.ToString();
                txtGram.Text = row.Cells["gvGram"].Value.ToString();
                txtStockQTY.Text = row.Cells["gvStockQTY"].Value.ToString();
                txtPerItemPrice.Text = row.Cells["gvPerItemPrice"].Value.ToString();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "gvStockQTY")
            {
                // Convert the cell value to integer
                int stockQty;
                if (int.TryParse(e.Value.ToString(), out stockQty))
                {
                    if (stockQty <= 50 && stockQty > 0)
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    else if (stockQty <= 0)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

    }
}
