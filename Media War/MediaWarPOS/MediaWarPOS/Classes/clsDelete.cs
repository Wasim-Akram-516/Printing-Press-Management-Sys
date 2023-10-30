using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWarPOS.Classes
{
    class clsDelete
    {
        public static void Delete(object ID, string procedure, string parameter)
        {
            try
            {
                SqlCommand com = new SqlCommand(procedure, clsMain.con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue(parameter, ID);
                clsMain.con.Open();
                int st = com.ExecuteNonQuery();
                clsMain.con.Close();
                if (st > 0)
                {
                    clsMain.ShowMsg("Data deleted successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }
    }
}
