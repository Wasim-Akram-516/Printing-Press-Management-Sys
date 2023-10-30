using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaWarPOS.Windows
{
    public partial class Products : Settings.WindowSample
    {
        public Products()
        {
            InitializeComponent();
        }
        Regex rgNumber = new Regex("^[.?\\d]+$");
        float retailPrice, perItemPrice, itemsNo;
        private int edit;
        int SuccessCount;
        private void Products_Load(object sender, EventArgs e)
        {
            Classes.clsMain.DisableReset(pnlDetails);
            LoadList();
        }
        private void LoadList()
        {
            Classes.clsMain.GetDropdownList("stpSelectStockCategoriesActive", ddStockCat, "name", "stockCatID");
            Classes.clsMain.GetDropdownList("stpSelectProductCategoriesActive", ddProductCat, "name", "prodCatID");
            Classes.clsMain.GetDropdownList("stpSelectBrandsActive", ddBrand, "name", "brandID");
        }

        private void ddStockCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(ddStockCat, errStcokCat);
        }

        private void ddProductCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(ddProductCat, errProductCat);
        }

        private void ddSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(ddBrand, errSupplier);
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtSize, errSize);
        }

        private void txtGram_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtGram, errGram);
        }

        private void txtCostPrice_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtCostPrice, errCostPrice);
            if (txtCostPrice.Text != "")
            {
                if (!rgNumber.Match(txtCostPrice.Text).Success)
                {
                    txtCostPrice.SelectAll();
                    txtCostPrice.Focus();
                    Classes.clsMain.ShowMsg("Invalid Format!", "Error", "Errror");
                }
            }
        }

        private void txtItemsNo_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtItemsNo, errItemsNo);
            if (txtItemsNo.Text != "")
            {
                if (!rgNumber.Match(txtItemsNo.Text).Success)
                {
                    txtItemsNo.SelectAll();
                    txtItemsNo.Focus();
                    Classes.clsMain.ShowMsg("Invalid Format!", "Error", "Errror");
                }
                else
                {
                    if (txtReatilPrice.Text != "" && txtItemsNo.Text != "")
                    {
                        retailPrice = Convert.ToSingle(txtReatilPrice.Text);
                        itemsNo = Convert.ToSingle(txtItemsNo.Text);
                        perItemPrice = retailPrice / itemsNo;
                        txtPerItemPrice.Text = perItemPrice.ToString();
                    }
                }
            }

        }

        private void txtQTY_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtQTY, errQTY);
            if (txtQTY.Text != "")
            {
                if (!rgNumber.Match(txtQTY.Text).Success)
                {
                    txtQTY.SelectAll();
                    txtQTY.Focus();
                    Classes.clsMain.ShowMsg("Invalid Format!", "Error", "Errror");
                }
            }
        }

        private void txtReatilPrice_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtReatilPrice, errRetailPrice);
            if (txtReatilPrice.Text != "")
            {
                if (!rgNumber.Match(txtReatilPrice.Text).Success)
                {
                    txtReatilPrice.SelectAll();
                    txtReatilPrice.Focus();
                    Classes.clsMain.ShowMsg("Invalid Format!", "Error", "Errror");
                }
                else
                {
                    if (txtReatilPrice.Text != "" && txtItemsNo.Text != "")
                    {
                        retailPrice = Convert.ToSingle(txtReatilPrice.Text);
                        itemsNo = Convert.ToSingle(txtItemsNo.Text);
                        perItemPrice = retailPrice / itemsNo;
                        txtPerItemPrice.Text = perItemPrice.ToString();
                    }
                }
            }

        }

        private void txtPerItemPrice_TextChanged(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(txtPerItemPrice, errPerItemPrice);
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            Classes.clsMain.ShowErr(ddStockCat, errStcokCat);
            Classes.clsMain.ShowErr(ddProductCat, errProductCat);
            Classes.clsMain.ShowErr(ddBrand, errSupplier);
            Classes.clsMain.ShowErr(txtSize, errSize);
            Classes.clsMain.ShowErr(txtGram, errGram);
            Classes.clsMain.ShowErr(txtCostPrice, errCostPrice);
            Classes.clsMain.ShowErr(txtItemsNo, errItemsNo);
            Classes.clsMain.ShowErr(txtQTY, errQTY);
            Classes.clsMain.ShowErr(txtReatilPrice, errRetailPrice);
            Classes.clsMain.ShowErr(txtPerItemPrice, errPerItemPrice);


            if (errStcokCat.Visible || errProductCat.Visible || errSupplier.Visible || errSize.Visible || errGram.Visible || errCostPrice.Visible || errItemsNo.Visible || errQTY.Visible || errRetailPrice.Visible || errPerItemPrice.Visible)
            {
                Classes.clsMain.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }

            else
            {
                dataGridView1.Rows.Add(ddStockCat.SelectedValue, ddStockCat.Text, ddProductCat.SelectedValue, ddProductCat.Text, ddBrand.SelectedValue, ddBrand.Text, txtSize.Text, txtGram.Text, txtCostPrice.Text, txtItemsNo.Text, txtQTY.Text, txtReatilPrice.Text, txtPerItemPrice.Text, dtDate.Value);
                lblTotal.Text = dataGridView1.Rows.Count.ToString();
                txtSize.Focus();
            }
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            Classes.clsMain.EnableReset(pnlDetails);
            ddStockCat.Focus();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            

            if (dataGridView1.Rows.Count==0)
            {
                Classes.clsMain.ShowMsg("Please, enter some products to save.", "Error", "Error");
            }
            else
            {
                if (edit == 0)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        try
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                int chk = Classes.clsInsert.InsertProducts(Convert.ToInt32(row.Cells["gvStockCatID"].Value ), Convert.ToInt32(row.Cells["gvProductCatID"].Value),
                                Convert.ToInt32(row.Cells["gvBrandID"].Value ), Convert.ToString(row.Cells["gvSize"].Value),Convert.ToString(row.Cells["gvGram"].Value), 
                                Convert.ToSingle(row.Cells["gvCostPrice"].Value), Convert.ToInt32(row.Cells["gvItemsNo"].Value), Convert.ToInt32(row.Cells["gvQTY"].Value),
                                Convert.ToSingle(row.Cells["gvRetailPrice"].Value), Convert.ToSingle(row.Cells["gvPerItemPrice"].Value), Convert.ToDateTime(row.Cells["gvDate"].Value));

                                if (chk > 0)
                                {
                                    Int64 productID = Classes.clsSelect.SelectProductID();

                                    // stock QTY will be the product of product QTY and items per pack
                                    int stockQTY = Convert.ToInt32(row.Cells["gvQTY"].Value) * Convert.ToInt32(row.Cells["gvItemsNo"].Value);

                                    int checkDetail = Classes.clsInsert.InsertStock(productID, stockQTY);

                                    if (checkDetail > 0)
                                    {
                                        SuccessCount++;
                                    }
                                }
                            }
                            
                            if (SuccessCount > 0)
                            {
                                Classes.clsMain.ShowMsg(SuccessCount + " Products Added Successfully!", "Success", "Success");
                                Classes.clsMain.DisableReset(pnlDetails);
                                dataGridView1.Rows.Clear();
                                lblTotal.Text = "";
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

        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 14)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    lblTotal.Text = (dataGridView1.Rows.Count - 1).ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }
        }
    }
}
