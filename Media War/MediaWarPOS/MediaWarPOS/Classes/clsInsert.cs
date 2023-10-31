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

        public static void InsertSalaries(int fkEmployeeID, int month, int year, DateTime date, float paidAmount, byte paymentType, string remarks)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpAddSalaries", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@fkEmployeeID", fkEmployeeID);
                com.Parameters.AddWithValue("@month", month);
                com.Parameters.AddWithValue("@year", year);
                com.Parameters.AddWithValue("@date", date);
                com.Parameters.AddWithValue("@paidAmount", paidAmount);
                com.Parameters.AddWithValue("@paymentType", paymentType);
                com.Parameters.AddWithValue("@remarks", remarks);

                clsMain.con.Open();
                com.ExecuteNonQuery();
                clsMain.con.Close();
                
                clsMain.ShowMsg("Salary details added successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static int AddExpenses(DateTime date, string ExpenseType, string Description, float Amount, string receiptName, string receiptNo)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stpAddExpenses", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Date", date);
                com.Parameters.AddWithValue("@ExpenseType", ExpenseType);
                com.Parameters.AddWithValue("@Description", Description);
                com.Parameters.AddWithValue("@Amount", Amount);
                com.Parameters.AddWithValue("@ReceiptName", receiptName);
                com.Parameters.AddWithValue("@ReceiptNo", receiptNo);
                clsMain.con.Open();
                st = com.ExecuteNonQuery();
                clsMain.con.Close();
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
            return st;
        }
        public static void InsertCustomers(string name, string phone1, string phone2, DateTime date, string workDetails)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpAddCustomers", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@phone1", phone1);
                if (phone2 != null)
                    com.Parameters.AddWithValue("@phone2", phone2);
                com.Parameters.AddWithValue("@date", date);
                com.Parameters.AddWithValue("@workDetails", workDetails);
                clsMain.con.Open();
                com.ExecuteNonQuery();
                clsMain.con.Close();
                clsMain.ShowMsg(name + " added successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

    }
}
