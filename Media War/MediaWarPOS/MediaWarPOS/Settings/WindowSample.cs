using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaWarPOS.Settings
{
    public partial class WindowSample : DashboardSample
    {
        public WindowSample()
        {
            InitializeComponent();
        }

        public virtual void btnBack_Click(object sender, EventArgs e)
        {
            Dashboards.dbAdmin obj = new Dashboards.dbAdmin();
            Classes.clsMain.ShowWindow(obj, this, MDI.ActiveForm);
        }

        public virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnSave_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnView_Click(object sender, EventArgs e)
        {

        }

        public virtual void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
