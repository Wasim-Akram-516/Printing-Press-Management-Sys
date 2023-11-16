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
    public partial class Categories : Settings.DashboardSample
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void btnStockCategories_Click(object sender, EventArgs e)
        {
            StockCategories obj = new StockCategories();
            Classes.clsMain.ShowWindow(obj, this, Settings.MDI.ActiveForm);
        }

        private void btnProductCategories_Click(object sender, EventArgs e)
        {
            ProductCategories obj = new ProductCategories();
            Classes.clsMain.ShowWindow(obj, this, Settings.MDI.ActiveForm);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboards.dbAdmin obj = new Dashboards.dbAdmin();
            Classes.clsMain.ShowWindow(obj, this,Settings.MDI.ActiveForm);
        }
    }
}
