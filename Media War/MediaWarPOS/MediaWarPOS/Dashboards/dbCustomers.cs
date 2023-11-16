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
    public partial class dbCustomers : Settings.DashboardSample
    {
        public dbCustomers()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dbAdmin obj = new dbAdmin();
            Classes.clsMain.ShowWindow(obj, this, Settings.MDI.ActiveForm);
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            Windows.CustomerDetails obj = new Windows.CustomerDetails();
            Classes.clsMain.ShowWindow(obj, this,Settings.MDI.ActiveForm);
        }

        private void btnWorkdetails_Click(object sender, EventArgs e)
        {
            Windows.WorkDetails obj = new Windows.WorkDetails();
            Classes.clsMain.ShowWindow(obj, this, Settings.MDI.ActiveForm);
        }

    }
}
