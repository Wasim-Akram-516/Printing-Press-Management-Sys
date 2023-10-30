using MediaWarPOS.Classes;
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
    public partial class Login : DashboardSample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            clsMain.ShowErr(txtUsername, errUsername);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            clsMain.ShowErr(txtPassword, errPassword);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsMain.ShowErr(txtUsername, errUsername);
            clsMain.ShowErr(txtPassword, errPassword);
            if (errUsername.Visible||errPassword.Visible)
            {
                clsMain.ShowMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {
                if (txtUsername.Text=="admin" && txtPassword.Text=="@mediawar2023")
                {
                    dbAdmin obj = new dbAdmin();
                    clsMain.ShowWindow(obj, this, MDI.ActiveForm);
                }
                else
                {
                    clsMain.ShowMsg("Username or Password is incorrect.", "Error", "Error");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
