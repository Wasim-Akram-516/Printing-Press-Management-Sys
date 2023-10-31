using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MediaWarPOS.Classes
{
    class clsSelect
    {
        public static void selectEmployees(DataGridView GV, DataGridViewColumn GVEMPLOYEEID, DataGridViewColumn GVNAME, DataGridViewColumn GVCNIC,
            DataGridViewColumn GVPHONE1, DataGridViewColumn GVPHONE2, DataGridViewColumn GVSALARY, DataGridViewColumn GVSTATUS,
             DataGridViewColumn GVJOININGDATE, DataGridViewColumn GVLEFTDATE, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stpSelectEmployees", clsMain.con);
                }
                else
                {
                    com = new SqlCommand("stpSearchEmployees", clsMain.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVEMPLOYEEID.DataPropertyName = dt.Columns["employeeID"].ToString();
                GVNAME.DataPropertyName = dt.Columns["name"].ToString();
                GVCNIC.DataPropertyName = dt.Columns["CNIC"].ToString();
                GVPHONE1.DataPropertyName = dt.Columns["phone1"].ToString();
                GVPHONE2.DataPropertyName = dt.Columns["phone2"].ToString();
                GVSALARY.DataPropertyName = dt.Columns["salary"].ToString();
                GVSTATUS.DataPropertyName = dt.Columns["Status"].ToString();
                GVJOININGDATE.DataPropertyName = dt.Columns["joiningDate"].ToString();
                GVLEFTDATE.DataPropertyName = dt.Columns["leftDate"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void selectInvestments(DataGridView GV, DataGridViewColumn GVINVESTMENTID, DataGridViewColumn GVNAME, DataGridViewColumn GVAMOUNT, DataGridViewColumn GVDATE, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stpSelectInvestments", clsMain.con);
                }
                else
                {
                    com = new SqlCommand("stpSearchInvestments", clsMain.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVINVESTMENTID.DataPropertyName = dt.Columns["investmentID"].ToString();
                GVNAME.DataPropertyName = dt.Columns["name"].ToString();
                GVAMOUNT.DataPropertyName = dt.Columns["amount"].ToString();
                GVDATE.DataPropertyName = dt.Columns["date"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void selectProductCategories(DataGridView GV, DataGridViewColumn GVPRODUCTCATID, DataGridViewColumn GVNAME, DataGridViewColumn GVSTATUS, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stpSelectProductCategories", clsMain.con);
                }
                else
                {
                    com = new SqlCommand("stpSearchProductCategories", clsMain.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVPRODUCTCATID.DataPropertyName = dt.Columns["prodCatID"].ToString();
                GVNAME.DataPropertyName = dt.Columns["name"].ToString();
                GVSTATUS.DataPropertyName = dt.Columns["status"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void selectStockCategories(DataGridView GV, DataGridViewColumn GVSTOCKCATID, DataGridViewColumn GVNAME, DataGridViewColumn GVSTATUS, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stpSelectStockCategories", clsMain.con);
                }
                else
                {
                    com = new SqlCommand("stpSearchStockCategories", clsMain.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVSTOCKCATID.DataPropertyName = dt.Columns["stockCatID"].ToString();
                GVNAME.DataPropertyName = dt.Columns["name"].ToString();
                GVSTATUS.DataPropertyName = dt.Columns["status"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void selectBrands(DataGridView GV, DataGridViewColumn GVBRANDID, DataGridViewColumn GVNAME, 
            DataGridViewColumn GVPHONE1, DataGridViewColumn GVPHONE2, DataGridViewColumn GVADDRESS, DataGridViewColumn GVSTATUS, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stpSelectBrands", clsMain.con);
                }
                else
                {
                    com = new SqlCommand("stpSearchBrands", clsMain.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVBRANDID.DataPropertyName = dt.Columns["brandID"].ToString();
                GVNAME.DataPropertyName = dt.Columns["name"].ToString();
                GVPHONE1.DataPropertyName = dt.Columns["phone1"].ToString();
                GVPHONE2.DataPropertyName = dt.Columns["phone2"].ToString();
                GVADDRESS.DataPropertyName = dt.Columns["address"].ToString();
                GVSTATUS.DataPropertyName = dt.Columns["status"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }
 
        public static void selectProducts(DataGridView GV, DataGridViewColumn GVSTOCKCATID, DataGridViewColumn GVSTOCKCATNAME,
            DataGridViewColumn GVPRDCATID, DataGridViewColumn GVPRODUCTCATNAME, DataGridViewColumn GVSUPPLIERID, DataGridViewColumn GVSUPPLIERNAME,
            DataGridViewColumn GVPRODUCTID, DataGridViewColumn GVSIZE, DataGridViewColumn GVGRAM, DataGridViewColumn GVCOSTPRICE,
            DataGridViewColumn GVITEMSNO, DataGridViewColumn GVQTY, DataGridViewColumn GVRETAILPRICE, DataGridViewColumn GVPERITEMPRICE, DataGridViewColumn GVDATE, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stpSelectProducts", clsMain.con);
                }
                else
                {
                    com = new SqlCommand("stpSearchProducts", clsMain.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVSTOCKCATID.DataPropertyName = dt.Columns["stockCatID"].ToString();
                GVSTOCKCATNAME.DataPropertyName = dt.Columns["stockCatName"].ToString();
                GVPRDCATID.DataPropertyName = dt.Columns["prodCatID"].ToString();
                GVPRODUCTCATNAME.DataPropertyName = dt.Columns["productCatName"].ToString();
                GVSUPPLIERID.DataPropertyName = dt.Columns["supplierID"].ToString();
                GVSUPPLIERNAME.DataPropertyName = dt.Columns["supplierName"].ToString();
                GVPRODUCTID.DataPropertyName = dt.Columns["productID"].ToString();
                GVSIZE.DataPropertyName = dt.Columns["size"].ToString();
                GVGRAM.DataPropertyName = dt.Columns["gram"].ToString();
                GVCOSTPRICE.DataPropertyName = dt.Columns["costPrice"].ToString();
                GVITEMSNO.DataPropertyName = dt.Columns["itemsNo"].ToString();
                GVQTY.DataPropertyName = dt.Columns["QTY"].ToString();
                GVRETAILPRICE.DataPropertyName = dt.Columns["retailPrice"].ToString();
                GVPERITEMPRICE.DataPropertyName = dt.Columns["perItemPrice"].ToString();
                GVDATE.DataPropertyName = dt.Columns["date"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static Int64 SelectProductID()
        {
            Int64 productID = 0;
            try
            {
                SqlCommand com = new SqlCommand("stpSelectProductID", Classes.clsMain.con);
                com.CommandType = CommandType.StoredProcedure;
                Classes.clsMain.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productID = Convert.ToInt64(dr[0]);
                    }
                }
                Classes.clsMain.con.Close();
            }
            catch (Exception x)
            {
                Classes.clsMain.con.Close();
                Classes.clsMain.ShowMsg(x.Message, "Error", "Error");
            }
            return productID;
        }

        public static void selectStock(DataGridView GV, DataGridViewColumn GVSTOCKCATID, DataGridViewColumn GVSTOCKCATNAME,
            DataGridViewColumn GVPRDCATID, DataGridViewColumn GVPRODUCTCATNAME, DataGridViewColumn GVBRANDID, DataGridViewColumn GVBRANDNAME,
            DataGridViewColumn GVPRODUCTID, DataGridViewColumn GVSIZE, DataGridViewColumn GVGRAM, DataGridViewColumn GVCOSTPRICE,
             DataGridViewColumn GVRETAILPRICE, DataGridViewColumn GVPERITEMPRICE, DataGridViewColumn GVITEMSNO, DataGridViewColumn GVQTY,
             DataGridViewColumn GVDATE, DataGridViewColumn GVSTOCKID, DataGridViewColumn GVSTOCKQTY, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stpSelectStock", clsMain.con);
                }
                else
                {
                    com = new SqlCommand("stpSearchStock", clsMain.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVSTOCKCATID.DataPropertyName = dt.Columns["stockCatID"].ToString();
                GVSTOCKCATNAME.DataPropertyName = dt.Columns["stockCatName"].ToString();
                GVPRDCATID.DataPropertyName = dt.Columns["prodCatID"].ToString();
                GVPRODUCTCATNAME.DataPropertyName = dt.Columns["productCatName"].ToString();
                GVBRANDID.DataPropertyName = dt.Columns["brandID"].ToString();
                GVBRANDNAME.DataPropertyName = dt.Columns["brandName"].ToString();
                GVPRODUCTID.DataPropertyName = dt.Columns["productID"].ToString();
                GVSIZE.DataPropertyName = dt.Columns["size"].ToString();
                GVGRAM.DataPropertyName = dt.Columns["gram"].ToString();
                GVCOSTPRICE.DataPropertyName = dt.Columns["costPrice"].ToString();
                GVRETAILPRICE.DataPropertyName = dt.Columns["retailPrice"].ToString();
                GVPERITEMPRICE.DataPropertyName = dt.Columns["perItemPrice"].ToString();
                GVITEMSNO.DataPropertyName = dt.Columns["itemsNo"].ToString();
                GVQTY.DataPropertyName = dt.Columns["QTY"].ToString();
                GVDATE.DataPropertyName = dt.Columns["PurchaseDate"].ToString();
                GVSTOCKID.DataPropertyName = dt.Columns["stockID"].ToString();
                GVSTOCKQTY.DataPropertyName = dt.Columns["stockQTY"].ToString();
                GV.DataSource = dt;
                GV.ClearSelection();
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void selectSales(DataGridView GV, DataGridViewColumn GVSTOCKCATID, DataGridViewColumn GVSTOCKCATNAME,
            DataGridViewColumn GVPRDCATID, DataGridViewColumn GVPRODUCTCATNAME, DataGridViewColumn GVBRANDID, DataGridViewColumn GVBRANDNAME,
            DataGridViewColumn GVPRODUCTID, DataGridViewColumn GVSIZE, DataGridViewColumn GVGRAM, DataGridViewColumn GVPERITEMPRICE, DataGridViewColumn GVSALEID, DataGridViewColumn GVQTY,
             DataGridViewColumn GVPRICE, DataGridViewColumn GVPURPOSE, DataGridViewColumn GVDATE,Label TOTALSALES,DateTime from,DateTime to)
        {
            try
            {
                SqlCommand com;
                com = new SqlCommand("stpSelectSales", clsMain.con);
                com.Parameters.AddWithValue("@from", from);
                com.Parameters.AddWithValue("@to", to);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds);

                // First result set: sales details
                DataTable dt = ds.Tables[0];

                GVSTOCKCATID.DataPropertyName = dt.Columns["stockCatID"].ToString();
                GVSTOCKCATNAME.DataPropertyName = dt.Columns["stockCatName"].ToString();
                GVPRDCATID.DataPropertyName = dt.Columns["prodCatID"].ToString();
                GVPRODUCTCATNAME.DataPropertyName = dt.Columns["productCatName"].ToString();
                GVBRANDID.DataPropertyName = dt.Columns["brandID"].ToString();
                GVBRANDNAME.DataPropertyName = dt.Columns["brandName"].ToString();
                GVPRODUCTID.DataPropertyName = dt.Columns["productID"].ToString();
                GVSIZE.DataPropertyName = dt.Columns["size"].ToString();
                GVGRAM.DataPropertyName = dt.Columns["gram"].ToString();
                GVPERITEMPRICE.DataPropertyName = dt.Columns["perItemPrice"].ToString();
                GVSALEID.DataPropertyName = dt.Columns["saleID"].ToString();
                GVQTY.DataPropertyName = dt.Columns["saleQTY"].ToString();
                GVPRICE.DataPropertyName = dt.Columns["price"].ToString();
                GVPURPOSE.DataPropertyName = dt.Columns["purpose"].ToString();
                GVDATE.DataPropertyName = dt.Columns["saleDate"].ToString();
                GV.DataSource = dt;

                // Second result set: total sales amount
                decimal totalSalesAmount;
                if (decimal.TryParse(ds.Tables[1].Rows[0]["TotalSales"].ToString(), out totalSalesAmount))
                {
                    TOTALSALES.Text = totalSalesAmount.ToString("N0", new CultureInfo("en-IN"));
                }
                else
                {
                    TOTALSALES.Text = "0";
                }
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void selectTotalPaidSalaryForEmployee(TextBox salaryTextBox,TextBox TotalPaidTextBox, int employeeID, int month, int year)
        {
            try
            {
                SqlCommand com;
                com = new SqlCommand("stpSelectTotalPaidSalaryForEmployee", clsMain.con);
                com.Parameters.AddWithValue("@employeeID", employeeID);
                com.Parameters.AddWithValue("@month", month);
                com.Parameters.AddWithValue("@year", year);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    salaryTextBox.Text = dt.Rows[0]["salary"].ToString();
                    TotalPaidTextBox.Text = dt.Rows[0]["totalPaid"].ToString();
                }
                    
                else
                {
                    salaryTextBox.Text = "0";
                    TotalPaidTextBox.Text = "0";
                }
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void selectSalaries(DataGridView GV, DataGridViewColumn GVEMPLOYEEID, DataGridViewColumn GVNAME,
            DataGridViewColumn GVSALARY, DataGridViewColumn GVSALARYID, DataGridViewColumn GVMONTH, DataGridViewColumn GVYEAR,
            DataGridViewColumn GVPAYMENTDATE, DataGridViewColumn GVPAIDAMOUNT, DataGridViewColumn GVTOTALPAID, DataGridViewColumn GVPAYMENTTYPE,
            DataGridViewColumn GVREMARKS, int month, int year)
        {
            try
            {
                SqlCommand com = new SqlCommand("stpSelectSalaries", clsMain.con);
                com.Parameters.AddWithValue("@month", month);
                com.Parameters.AddWithValue("@year", year);
                com.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                GVEMPLOYEEID.DataPropertyName = dt.Columns["employeeID"].ToString();
                GVNAME.DataPropertyName = dt.Columns["name"].ToString();
                GVSALARY.DataPropertyName = dt.Columns["salary"].ToString();
                GVSALARYID.DataPropertyName = dt.Columns["salaryID"].ToString();
                GVMONTH.DataPropertyName = dt.Columns["month"].ToString();
                GVYEAR.DataPropertyName = dt.Columns["year"].ToString();
                GVPAYMENTDATE.DataPropertyName = dt.Columns["paymentDate"].ToString();
                GVPAIDAMOUNT.DataPropertyName = dt.Columns["paidAmount"].ToString();
                GVTOTALPAID.DataPropertyName = dt.Columns["totalPaid"].ToString();
                GVPAYMENTTYPE.DataPropertyName = dt.Columns["paymentType"].ToString();
                GVREMARKS.DataPropertyName = dt.Columns["remarks"].ToString();

                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void selectExpenses(DataGridView GV, DataGridViewColumn GVdate,
             DataGridViewColumn GVexpenseType, DataGridViewColumn GVdescription, DataGridViewColumn GVamount, DataGridViewColumn GVreceiptName,
             DataGridViewColumn GVreceiptNo, DataGridViewColumn GVexpenseID, DateTime? startDate = null, DateTime? endDate = null, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stpSelectExpenses", clsMain.con);
                    if (startDate.HasValue)
                        com.Parameters.AddWithValue("@startDate", startDate.Value);
                    if (endDate.HasValue)
                        com.Parameters.AddWithValue("@endDate", endDate.Value);
                }
                else
                {
                    com = new SqlCommand("stpSearchExpenses", clsMain.con);
                    com.Parameters.AddWithValue("@data", data);
                    if (startDate.HasValue)
                        com.Parameters.AddWithValue("@startDate", startDate.Value);
                    if (endDate.HasValue)
                        com.Parameters.AddWithValue("@endDate", endDate.Value);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVdate.DataPropertyName = dt.Columns["date"].ToString();
                GVexpenseType.DataPropertyName = dt.Columns["expenseType"].ToString();
                GVdescription.DataPropertyName = dt.Columns["description"].ToString();
                GVamount.DataPropertyName = dt.Columns["amount"].ToString();
                GVreceiptName.DataPropertyName = dt.Columns["receiptName"].ToString();
                GVreceiptNo.DataPropertyName = dt.Columns["receiptNo"].ToString();
                GVexpenseID.DataPropertyName = dt.Columns["expenseID"].ToString();

                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void selectCustomers(DataGridView GV, DataGridViewColumn GVCUSTOMERID, DataGridViewColumn GVNAME, DataGridViewColumn GVPHONE1,
            DataGridViewColumn GVPHONE2, DataGridViewColumn GVDATE, DataGridViewColumn GVWORKDETAILS, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stpSelectCustomers", clsMain.con);
                }
                else
                {
                    com = new SqlCommand("stpSearchCustomers", clsMain.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVCUSTOMERID.DataPropertyName = dt.Columns["customerID"].ToString();
                GVNAME.DataPropertyName = dt.Columns["name"].ToString();
                GVPHONE1.DataPropertyName = dt.Columns["phone1"].ToString();
                GVPHONE2.DataPropertyName = dt.Columns["phone2"].ToString();
                GVDATE.DataPropertyName = dt.Columns["date"].ToString();
                GVWORKDETAILS.DataPropertyName = dt.Columns["workDetails"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                clsMain.con.Close();
                clsMain.ShowMsg(x.Message, "Error", "Error");
            }
        }

    }
}
