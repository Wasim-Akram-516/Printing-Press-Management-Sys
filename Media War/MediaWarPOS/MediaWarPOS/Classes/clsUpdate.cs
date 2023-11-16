using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWarPOS.Classes
{
    class clsUpdate
    {
        public static void UpdateEmployees(int employeeID, string name, string CNIC, string phone1, string phone2, float salary, Int16 status, DateTime joiningDate, DateTime leftDate)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpUpdateEmployees", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@employeeID", employeeID);
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
                clsMain.ShowMsg(name + " updated successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }
        public static void UpdateInvestments(int investmentID,string name, float amount, DateTime date)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpUpdateInvestments", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@investmentID", investmentID);
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@amount", amount);
                com.Parameters.AddWithValue("@Date", date);
                clsMain.con.Open();
                com.ExecuteNonQuery();
                clsMain.con.Close();
                clsMain.ShowMsg(name + " updated successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateProductCategories(int prodCatID,string name, Int16 status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpUpdateProductCategories", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@prodCatID", prodCatID);
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@status", status);
                clsMain.con.Open();
                com.ExecuteNonQuery();
                clsMain.con.Close();
                clsMain.ShowMsg(name + " updated successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }
        public static void UpdateStockCategories(int stockCatID,string name, Int16 status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpUpdateStockCategories", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@stockCatID", stockCatID);
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@status", status);
                clsMain.con.Open();
                com.ExecuteNonQuery();
                clsMain.con.Close();
                clsMain.ShowMsg(name + " updated successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateBrands(int brandID, string name, string phone1, string phone2, string address, Int16 status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpUpdateBrands", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@brandID", brandID);
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@phone1", phone1);
                com.Parameters.AddWithValue("@phone2", phone2);
                com.Parameters.AddWithValue("@address", address);
                com.Parameters.AddWithValue("@status", status);
                clsMain.con.Open();
                com.ExecuteNonQuery();
                clsMain.con.Close();
                clsMain.ShowMsg(name + " updated successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }
        public static void UpdateProducts(Int64 productID,int fkStockCatID, int fkProdCatID, int fkSupplierID, string size, string gram, float costPrice, int itemsNo, int QTY,
            float retailPrice, float perItemPrice, DateTime date)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpUpdateProducts", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@productID", productID);
                com.Parameters.AddWithValue("@fkStockCatID", fkStockCatID);
                com.Parameters.AddWithValue("@fkProdCatID", fkProdCatID);
                com.Parameters.AddWithValue("@fkSupplierID", fkSupplierID);
                com.Parameters.AddWithValue("@size", size);
                com.Parameters.AddWithValue("@gram", gram);
                com.Parameters.AddWithValue("@costPrice", costPrice);
                com.Parameters.AddWithValue("@itemsNo", itemsNo);
                com.Parameters.AddWithValue("@QTY", QTY);
                com.Parameters.AddWithValue("@retailPrice", retailPrice);
                com.Parameters.AddWithValue("@perItemPrice", perItemPrice);
                com.Parameters.AddWithValue("@date", date);
                clsMain.con.Open();
                com.ExecuteNonQuery();
                clsMain.con.Close();
                clsMain.ShowMsg(size + " updated successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {

                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static int UpdateStock(long stockID, int QTY)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stpUpdateStock", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@stockID", stockID);
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

        public static void UpdateSalaries(long salaryID, int fkEmployeeID, int month, int year, DateTime date, float paidAmount, byte paymentType, string remarks)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpUpdateSalaries", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@salaryID", salaryID);
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

                clsMain.ShowMsg("Salary details updated successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static int UpdateExpenses(int expenseID, DateTime date, string expenseType, string description, float amount, string receiptName, string receiptNo)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stpUpdateExpenses", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@expenseID", expenseID);
                com.Parameters.AddWithValue("@date", date);
                com.Parameters.AddWithValue("@expenseType", expenseType);
                com.Parameters.AddWithValue("@description", description);
                com.Parameters.AddWithValue("@amount", amount);
                com.Parameters.AddWithValue("@receiptName", receiptName);
                com.Parameters.AddWithValue("@receiptNo", receiptNo);
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
        public static void UpdateCustomerDetails(int customerID, string name, string phone1, string phone2)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpUpdateCustomerDetails", clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@customerID", customerID);
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@phone1", phone1);
                if (!string.IsNullOrEmpty(phone2))
                    com.Parameters.AddWithValue("@phone2", phone2);
                else
                    com.Parameters.AddWithValue("@phone2", DBNull.Value);

                clsMain.con.Open();
                com.ExecuteNonQuery();
                clsMain.con.Close();
                clsMain.ShowMsg(name + " updated successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateWorkDetails(int workDetailID, int fkCustomerID, DateTime date, string workDetails, decimal totalPrice, decimal paid, decimal remaining, bool isDelivered)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpUpdateWorkDetails", clsMain.con); 
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@workDetailID", workDetailID);
                com.Parameters.AddWithValue("@CustomerID", fkCustomerID);
                com.Parameters.AddWithValue("@date", date);
                com.Parameters.AddWithValue("@workDetails", workDetails);
                com.Parameters.AddWithValue("@totalPrice", totalPrice);
                com.Parameters.AddWithValue("@paid", paid);
                com.Parameters.AddWithValue("@remaining", remaining);
                com.Parameters.AddWithValue("@isDelivered", isDelivered);

                clsMain.con.Open();
                com.ExecuteNonQuery();
                clsMain.con.Close();
                clsMain.ShowMsg("Work details updated successfully!", "Success!", "Success");
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

    }
}
