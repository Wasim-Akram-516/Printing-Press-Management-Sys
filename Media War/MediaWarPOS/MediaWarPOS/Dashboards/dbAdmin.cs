using MediaWarPOS.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaWarPOS.Dashboards
{
    public partial class dbAdmin : DashboardSample
    {
        public dbAdmin()
        {
            InitializeComponent();
        }
        private void dbAdmin_Load(object sender, EventArgs e)
        {
            Classes.clsSelect.selectStock(dataGridView1, gvStockCatID, gvStockCatName, gvProductCatID, gvProdCatName, gvBrandID, gvBrandName, gvProductID,
                gvSize, gvGram, gvCostPrice, gvRetailPrice, gvPerItemPrice, gvItemsNo, gvQTY, gvDate, gvStockID, gvStockQTY);
            Classes.clsMain.SNO(dataGridView1, "gvSNO");
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
        private void btnInvestment_Click(object sender, EventArgs e)
        {
            Windows.Investments obj = new Windows.Investments();
            Classes.clsMain.ShowWindow(obj, this, MDI.ActiveForm);
        }
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Windows.Employees obj = new Windows.Employees();
            Classes.clsMain.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnSuppliers_Click_1(object sender, EventArgs e)
        {
            Windows.Brands obj = new Windows.Brands();
            Classes.clsMain.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnCategories_Click_1(object sender, EventArgs e)
        {
            Windows.Categories obj = new Windows.Categories();
            Classes.clsMain.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnProducts_Click_1(object sender, EventArgs e)
        {
            Windows.Products obj = new Windows.Products();
            Classes.clsMain.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {
            Windows.Stock obj = new Windows.Stock();
            Classes.clsMain.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void LinkBtnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboards.Login obj = new Login();
            Classes.clsMain.ShowWindow(obj, this, MDI.ActiveForm);
        }
        
        private void btnSales_Click(object sender, EventArgs e)
        {
            Windows.Sales obj = new Windows.Sales();
            Classes.clsMain.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void btnSalaries_Click(object sender, EventArgs e)
        {
            Windows.Salaries obj = new Windows.Salaries();
            Classes.clsMain.ShowWindow(obj, this, MDI.ActiveForm);
        }
    }
}
