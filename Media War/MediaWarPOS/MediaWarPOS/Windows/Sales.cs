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
    public partial class Sales : Settings.WindowSample
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            Classes.clsSelect.selectSales(dataGridView1, gvStockCatID, gvStockCatName, gvProductCatID, gvProdCatName, gvBrandID, gvBrandName, gvProductID,
                gvSize, gvGram, gvPerItemPrice,gvSaleID,gvQTY,gvPrice,gvPurpose, gvDate,lblTotalSales,dtStart.Value,dtEnd.Value);
            Classes.clsMain.SNO(dataGridView1, "gvSNO");
        }
    }
}
