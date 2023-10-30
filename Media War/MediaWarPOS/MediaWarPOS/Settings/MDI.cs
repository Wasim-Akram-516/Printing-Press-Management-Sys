using MediaWarPOS.Classes;
using MediaWarPOS.Dashboards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaWarPOS.Settings
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            Login obj=new Login();
            settings set=new settings();
            if (File.Exists(clsMain.path+"\\connect"))
            {
                clsMain.ShowWindow(obj, MDI.ActiveForm);
            }
            else
            {
                clsMain.ShowWindow(set, MDI.ActiveForm);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings obj = new settings();
            Classes.clsMain.ShowWindow(obj, MDI.ActiveForm);
        }
    }
}
