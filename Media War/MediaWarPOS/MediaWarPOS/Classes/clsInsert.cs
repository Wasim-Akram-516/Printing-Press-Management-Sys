using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWarPOS.Classes
{
    class clsInsert
    {
        public static void InsertEmployees(string name, string CNIC, string phone1, string phone2, float salary, Int16 status,DateTime joiningDate,DateTime leftDate)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpAddEmployees", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@CNIC", CNIC);
                com.Parameters.AddWithValue("@phone1", phone1);
                com.Parameters.AddWithValue("@phone2", phone2);
                com.Parameters.AddWithValue("@salary", salary);
                com.Parameters.AddWithValue("@status", status);
                com.Parameters.AddWithValue("@joiningDate", joiningDate);
                com.Parameters.AddWithValue("@leftDate", leftDate);
                clsMain.con.Open();
                com.ExecuteNonQuery();
                clsMain.con.Close();
                clsMain.ShowMsg(name + " added successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void InsertInvestments(string name, float amount,  DateTime date)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpAddInvestments", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@amount", amount);
                com.Parameters.AddWithValue("@Date", date);
                clsMain.con.Open();
                com.ExecuteNonQuery();
                clsMain.con.Close();
                clsMain.ShowMsg(name + " added successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void InsertProductCategories(string name,  Int16 status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpAddProductCategories", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@status", status);
                clsMain.con.Open();
                com.ExecuteNonQuery();
                clsMain.con.Close();
                clsMain.ShowMsg(name + " added successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void InsertStockCategories(string name, Int16 status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpAddStockCategories", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@status", status);
                clsMain.con.Open();
                com.ExecuteNonQuery();
                clsMain.con.Close();
                clsMain.ShowMsg(name + " added successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void InsertBrands(string name, string phone1, string phone2,string address, Int16 status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpAddBrands", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@phone1", phone1);
                com.Parameters.AddWithValue("@phone2", phone2);
                com.Parameters.AddWithValue("@address", address);
                com.Parameters.AddWithValue("@status", status);
                clsMain.con.Open();
                com.ExecuteNonQuery();
                clsMain.con.Close();
                clsMain.ShowMsg(name + " added successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }
        
        public static int InsertProducts(int fkStockCatID,int fkProdCatID,int fkBrandID,string size, string gram, float costPrice, int itemsNo, int QTY,
            float retailPrice, float perItemPrice, DateTime date)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stpAddProducts", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@fkStockCatID", fkStockCatID);
                com.Parameters.AddWithValue("@fkProdCatID", fkProdCatID);
                com.Parameters.AddWithValue("@fkBrandID", fkBrandID);
                com.Parameters.AddWithValue("@size", size);
                com.Parameters.AddWithValue("@gram", gram);
                com.Parameters.AddWithValue("@costPrice", costPrice);
                com.Parameters.AddWithValue("@itemsNo", itemsNo);
                com.Parameters.AddWithValue("@QTY", QTY);
                com.Parameters.AddWithValue("@retailPrice", retailPrice);
                com.Parameters.AddWithValue("@perItemPrice", perItemPrice);
                com.Parameters.AddWithValue("@date", date);
                clsMain.con.Open();
                st = com.ExecuteNonQuery();
                clsMain.con.Close();
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
            return st;
        }

        public static int InsertStock(Int64 fkProductID, int QTY)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stpAddStock", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@fkProductID", fkProductID);
                com.Parameters.AddWithValue("@QTY", QTY);
                clsMain.con.Open();
                st=com.ExecuteNonQuery();
                clsMain.con.Close();
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
            return st;
        }

        public static int InsertSales(Int64 fkStockID, int QTY,float perItemPrice,string purpose, DateTime date, float price)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stpAddSales", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@fkStockID", fkStockID);
                com.Parameters.AddWithValue("@QTY", QTY);
                com.Parameters.AddWithValue("@perItemPrice", perItemPrice);
                com.Parameters.AddWithValue("@purpose", purpose);
                com.Parameters.AddWithValue("@date", date);
                com.Parameters.AddWithValue("@price", price);
                clsMain.con.Open();
                st = com.ExecuteNonQuery();
                clsMain.con.Close();
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
            return st;
        }
    }
}
