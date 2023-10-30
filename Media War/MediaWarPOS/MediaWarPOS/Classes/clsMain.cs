using MediaWarPOS.Settings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaWarPOS.Classes
{
    internal class clsMain
    {
        public static string path= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string conn = "";
        public static string ConStr()
        {
            if (File.Exists(path+"\\connect"))
            {
                conn = File.ReadAllText(path + "\\connect");
            }
            else
            {
                Settings.settings obj = new Settings.settings();
                obj.MdiParent = MDI.ActiveForm;
                obj.WindowState = FormWindowState.Maximized;
                obj.Show();
            }
            return conn;
        }

        public static SqlConnection con = new SqlConnection(ConStr());

        public static void ShowWindow(Form open, Form close, Form mdi)
        {
            close.Close();
            open.MdiParent=MDI.ActiveForm;
            open.WindowState = FormWindowState.Maximized;
            open.Show();
        }
        public static void ShowWindow(Form open, Form mdi)
        {
            open.MdiParent = MDI.ActiveForm;
            open.WindowState = FormWindowState.Maximized;
            open.Show();
        }
        public static void ShowErr(TextBox textbox,Label errLbl)
        {
            if (textbox.Text == "") { errLbl.Visible = true; } else { errLbl.Visible = false; }
        }
        public static void ShowErr(ComboBox dropDown,Label errLbl)
        {
            if (dropDown.SelectedIndex == 0 || dropDown.SelectedIndex==-1) { errLbl.Visible = true; } else { errLbl.Visible = false; }
        }

        public static DialogResult ShowMsg(string msg, string heading, string type)
        {
            if (type=="Success")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SNO(DataGridView gv, string columnName)
        {
            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[columnName].Value = count;
            }
        }
        public static void GetDropdownList(string procedure, ComboBox cb, string DisplayMember, string ValueMember)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                SqlCommand com = new SqlCommand(procedure, con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "~~~Select~~~" };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = dt;
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void GetDropdownListWithOneParameters(string procedure, ComboBox cb, string DisplayMember, string ValueMember, string param1, object val1)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                SqlCommand com = new SqlCommand(procedure, clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue(param1, val1);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "~~~Select~~~" };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = dt;
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void GetDropdownListWithTwoParameters(string procedure, ComboBox cb, string DisplayMember, string ValueMember, string param1, object val1, string param2, object val2)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                SqlCommand com = new SqlCommand(procedure, clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue(param1, val1);
                com.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "~~~Select~~~" };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = dt;
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void GetDropdownListWithThreeParameters(string procedure, ComboBox cb, string DisplayMember, string ValueMember, string param1, object val1, string param2, object val2, string param3, object val3)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                SqlCommand com = new SqlCommand(procedure, clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue(param1, val1);
                com.Parameters.AddWithValue(param2, val2);
                com.Parameters.AddWithValue(param3, val3);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "~~~Select~~~" };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = dt;
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void GetDropdownListWithFourParameters(string procedure, ComboBox cb, string DisplayMember, string ValueMember, string param1, object val1, string param2, object val2, string param3, object val3, string param4, object val4)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                SqlCommand com = new SqlCommand(procedure, clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue(param1, val1);
                com.Parameters.AddWithValue(param2, val2);
                com.Parameters.AddWithValue(param3, val3);
                com.Parameters.AddWithValue(param4, val4);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "~~~Select~~~" };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = dt;
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void DisableReset(Panel p)
        {
            foreach (Control ctr in p.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = false;
                    txt.Text = "";
                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = false;
                    rb.Checked = false;
                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = false;
                    chk.Checked = false;
                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = false;
                    dtp.Value = DateTime.Now;
                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = false;

                }
                if (ctr is PictureBox)
                {
                    PictureBox pic = (PictureBox)ctr;
                    pic.Image = null;

                }
                if (ctr is ListBox)
                {
                    ListBox lb = (ListBox)ctr;
                    lb.Enabled = false;
                    lb.ClearSelected();
                }
            }
        }

        public static void Disable(Panel p)
        {
            foreach (Control ctr in p.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = false;

                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = false;

                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = false;

                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = false;

                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = false;

                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = false;

                }
                if (ctr is ListBox)
                {
                    ListBox lb = (ListBox)ctr;
                    lb.Enabled = false;
                }
            }
        }

        public static void EnableReset(Panel p)
        {
            foreach (Control ctr in p.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = true;
                    txt.Text = "";
                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = true;
                    cb.SelectedIndex = 0;
                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = true;
                    chk.Checked = false;
                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = true;

                }
                if (ctr is PictureBox)
                {
                    PictureBox pic = (PictureBox)ctr;
                    pic.Image = null;

                }
                if (ctr is ListBox)
                {
                    ListBox lb = (ListBox)ctr;
                    lb.Enabled = true;
                    lb.ClearSelected();
                }
            }
        }

        public static void Enable(Panel p)
        {
            foreach (Control ctr in p.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = true;

                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = true;

                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = true;

                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = true;

                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = true;

                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = true;

                }
                if (ctr is ListBox)
                {
                    ListBox lb = (ListBox)ctr;
                    lb.Enabled = true;
                }
            }
        }

        public static void EnableReset(GroupBox gb)
        {
            foreach (Control ctr in gb.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Enabled = true;
                    txt.Text = "";
                }
                if (ctr is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctr;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (ctr is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctr;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (ctr is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctr;
                    chk.Enabled = true;
                    chk.Checked = false;
                }
                if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (ctr is Button)
                {
                    Button btn = (Button)ctr;
                    btn.Enabled = true;

                }
                if (ctr is PictureBox)
                {
                    PictureBox pic = (PictureBox)ctr;
                    pic.Image = null;

                }
                if (ctr is ListBox)
                {
                    ListBox lb = (ListBox)ctr;
                    lb.Enabled = true;
                    lb.ClearSelected();
                }
            }
        }

        

        
    }
}
