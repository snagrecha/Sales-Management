using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using System.Diagnostics;

namespace Sales_Management
{
    internal class DBHandler
    {
        public static string posConnectionString = $"Server = {Home.posServerName};Database={Home.posDBName};User Id = {Home.posUserName}; Password={Home.posPwd};";

        public static SqlConnection GetConnection(string serverName, string databaseName, bool windowsAuthentication = false)
        {
            string uid = "";
            string pwd = "";
            if (serverName.Equals(Home.posServerName))
            {
                uid = Home.posUserName;
                pwd = Home.posPwd;
            }

            else
            {
                uid = Home.smUserName; 
                pwd = Home.smPwd;
            }

            string connString = "Server=" + serverName + ";Database=" + databaseName + ";User Id = " + uid + "; Password=" + pwd + ";";

            if (windowsAuthentication) { connString = "Server=" + serverName + ";Database=" + databaseName + "; Integrated Security = true;"; }

            SqlConnection connection = new SqlConnection(connString);
            return connection;
        }

        public static int AddDailyTransaction(string date, string type, string particulars, int amount)
        {
            int added = 0;
            try
            {
                using (SqlConnection connection = GetConnection(Home.smServerName, Home.smDBName))
                {
                    connection.Open();

                    // Define the SQL query
                    string query = $"INSERT INTO DailyTransactions (Date, Type, Particular, Amount) VALUES ('{date}', '{type}', '{particulars}', {amount})";

                    Debug.WriteLine(query);

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }
                Console.WriteLine("Transaction successfully inserted into DailyTransactions table.");
                added = 1;
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                added = 0;
            }
            return added;
        }

        public static int UpdateQuery(string tableName, string set, string whereClause)
        {
            try
            {
                using (SqlConnection connection = GetConnection(Home.smServerName, Home.smDBName))
                {
                    connection.Open();

                    // Define the SQL query
                    string query = $"UPDATE {tableName} SET {set} WHERE {whereClause}";
                    Debug.WriteLine(query);

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Update Query: {ex.Message}");
                return 0;
            }
        }

        public static int InsertNewDay()
        {
            try
            {
                using (SqlConnection connection = GetConnection(Home.smServerName, Home.smDBName))
                {
                    connection.Open();

                    // Define the SQL query
                    string query = @"INSERT INTO DailyCash (Date, x500, x200, x100, x50, x20, x10, x5, x2, x1, FirstOpen) VALUES (@Date, 0, 0, 0, 0, 0, 0, 0, 0, 0, @FirstOpen)";

                    Debug.WriteLine(query);
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@Date", DateTime.Today);
                        command.Parameters.AddWithValue("@FirstOpen", DateTime.Now.ToShortTimeString());
                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("New day record successfully inserted.");
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting new day record: {ex.Message}");
                return 0;
            }
        }

        public static DailyCash GetDailyCash(string date)
        {
            //DataTable dataTable = new DataTable();
            DailyCash cashDetails = null;

            //try
            //{
                using (SqlConnection connection = GetConnection(Home.smServerName, Home.smDBName))
                {
                    connection.Open();

              
                    //if (type.Length > 0) type = " AND type = '" + type + "'";
                    // Define the SQL query
                    string query = $"SELECT * FROM DailyCash WHERE Date = '{date}'";
                    Debug.WriteLine(query);

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        /*// Execute the query and fill the DataTable with the results
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }*/

                        // Execute the query and read the data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cashDetails = new DailyCash
                                {
                                    Date = (DateTime)reader["Date"],
                                    x500 = (int)reader["x500"],
                                    x200 = (int)reader["x200"],
                                    x100 = (int)reader["x100"],
                                    x50 = (int)reader["x50"],
                                    x20 = (int)reader["x20"],
                                    x10 = (int)reader["x10"],
                                    x5 = (int)reader["x5"],
                                    x2 = (int)reader["x2"],
                                    x1 = (int)reader["x1"],
                                    Submitted = reader["Submitted"] as DateTime?,
                                    Emailed = reader["Emailed"] as DateTime?,
                                    Verified = reader["Verified"] as DateTime?,
                                    Printed = reader["Printed"] as DateTime?,
                                    Edited = reader["Edited"] as DateTime?,
                                    Initialised = reader["Initialized"] as DateTime?,
                                    FirstStart = reader["FirstOpen"] as DateTime?,
                                    LastClose = reader["LastClose"] as DateTime?,
                                    Deposited = reader["Deposited"] as DateTime?,
                                    totalSale = (int)reader["totalSale"],
                                    cashSale = (int)reader["cashSale"],
                                    cardSale = (int)reader["cardSale"],
                                    upiSale = (int)reader["upiSale"],
                                    bajajSale = (int)reader["bajajSale"],
                                    startBill = reader["startBill"].ToString(),
                                    endBill = reader["endBill"].ToString(),
                                    debitSale = (int)reader["debitSale"],
                                    balReceivedCash = (int)reader["balReceivedCash"],
                                    balReceivedCard = (int)reader["balReceivedCard"],
                                    crntIssued = (int)reader["crntIssued"],
                                    crntReceived = (int)reader["crntReceived"]
                                };
                            }
                        }
                    }
                }

                //Console.WriteLine("Data successfully retrieved from DailyTransactions table.");
            //}
            /*catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving data: {ex.Message}");
            }*/

            //return dataTable;
            return cashDetails;
        }

        public static DataTable GetDailyTransactions(string date, string type = "")
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = GetConnection(Home.smServerName, Home.smDBName))
                {
                    connection.Open();

                    if(type.Length > 0) type = " AND type = '" + type + "'";
                    // Define the SQL query
                    string query = $"SELECT * FROM DailyTransactions WHERE Date = '{date}' {type}";
                    Debug.WriteLine(query);

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                
                        // Execute the query and fill the DataTable with the results
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }

                //Console.WriteLine("Data successfully retrieved from DailyTransactions table.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving data: {ex.Message}");
            }

            return dataTable;
        }

        public static int DeleteFromDailyTransaction(string date, string type, string particular, string amount, string top = "1")
        {
            int deleted = 0;
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = GetConnection(Home.smServerName, Home.smDBName))
                {
                    connection.Open();

                    if (top.Equals("*")) top = "";
                    else top = $" TOP ({top})";
                    // Define the SQL query
                    string query = $"DELETE {top} FROM DailyTransactions WHERE Date = '{date}' AND type = '{type}' AND particular = '{particular}' AND amount = '{amount}'";
                    Debug.WriteLine(query);

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        // Execute the query and fill the DataTable with the results
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                deleted = 1;
                //Console.WriteLine("Data successfully retrieved from DailyTransactions table.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving data: {ex.Message}");
                deleted = 0;
            }
            return deleted;
        }

        public static SaleParameters GetDailySales(String serverName, String dbname, String date)
        {
            int netAmt = 0;
            int cashAmt = 0;
            int cardAmt = 0;
            int debitAmt = 0;
            int balReceivedAmt_cash = 0;
            int balReceivedAmt_card = 0;
            int paytm = 0;
            int bajaj = 0;
            int crntIssued = 0;
            int crntRecv = 0;
            string startBillNo = "";
            string endBillNo = "";

            

            SqlConnection con = GetConnection(serverName, dbname);


            //String query = "SELECT BIL_NO, DB_CODE, BIL_DT, CO_YEAR, PHONE, TOT_AMT, AC_NAME FROM SALE_DATA WHERE BIL_NO > '" + billNo + "' AND DB_CODE = '" + dbCode + "' AND CO_YEAR = '" + year + "'";
            String query = "SELECT SUM(NetAmt) AS NetAmt, SUM(CardAmt) AS CardAmt, SUM(CashAmt) AS CashAmt, SUM(OsAmt) AS OsAmt, SUM(CreditNoteIssueAmt) AS CrntIssued, SUM(CreditNoteUseAmt) AS CrntRecv, MIN(VoucherNo) AS StartBillNo, MAX(VoucherNo) AS EndBillNo FROM trnSales WHERE VoucherDate = '" + date + "'";
            String query2 = "SELECT SUM(CashAmt) AS CashReceiptAmt, SUM(CardAmt) AS CardReceiptAmt FROM trnBillWiseReceiptAcct WHERE AddDate >= '" + date + "'";
            String query3 = "SELECT CardAccountID, SUM(CardAmt) AS AltCardAmt FROM trnPaymentDetail WHERE AddDate >= '" + date + "' AND CardAccountID IN (" + Home.paytmId + "," + Home.bajajId + ") GROUP BY CardAccountID";

            Debug.WriteLine(query);

            Debug.WriteLine(query2);

            Debug.WriteLine(query3);

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, con);
            SqlDataAdapter adapter3 = new SqlDataAdapter(query3, con);

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();

            adapter.Fill(dt);
            adapter2.Fill(dt2);
            adapter3.Fill(dt3);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["NetAmt"].ToString().Length > 0) netAmt = int.Parse(dt.Rows[0]["NetAmt"].ToString());
                if (dt.Rows[0]["CashAmt"].ToString().Length > 0) cashAmt = int.Parse(dt.Rows[0]["CashAmt"].ToString());
                if (dt.Rows[0]["CardAmt"].ToString().Length > 0) cardAmt = int.Parse(dt.Rows[0]["CardAmt"].ToString());
                if (dt.Rows[0]["OsAmt"].ToString().Length > 0) debitAmt = int.Parse(dt.Rows[0]["OsAmt"].ToString());
                if (dt.Rows[0]["CrntIssued"].ToString().Length > 0) crntIssued = int.Parse(dt.Rows[0]["CrntIssued"].ToString());
                if (dt.Rows[0]["CrntRecv"].ToString().Length > 0) crntRecv = int.Parse(dt.Rows[0]["CrntRecv"].ToString());
                if (dt.Rows[0]["StartBillNo"].ToString().Length > 0) startBillNo = dt.Rows[0]["StartBillNo"].ToString();
                if (dt.Rows[0]["EndBillNo"].ToString().Length > 0) endBillNo = dt.Rows[0]["EndBillNo"].ToString();

            }

            if (dt2.Rows.Count > 0)
            {
                if (dt2.Rows[0]["CashReceiptAmt"].ToString().Length > 0) balReceivedAmt_cash = int.Parse(dt2.Rows[0]["CashReceiptAmt"].ToString());

                if (dt2.Rows[0]["CardReceiptAmt"].ToString().Length > 0) balReceivedAmt_card = int.Parse(dt2.Rows[0]["CardReceiptAmt"].ToString());
            }

            if (dt3.Rows.Count > 0)
            {
                foreach (DataRow row in dt3.Rows)
                {
                    if (row["CardAccountID"].ToString().Equals(Home.paytmId)) paytm = int.Parse(row["AltCardAmt"].ToString());
                    if (row["CardAccountID"].ToString().Equals(Home.bajajId)) bajaj = int.Parse(row["AltCardAmt"].ToString());
                }
            }

            cardAmt = cardAmt - paytm - bajaj;

            SaleParameters sales = new SaleParameters(netAmt, cashAmt, cardAmt, debitAmt, balReceivedAmt_cash, balReceivedAmt_card, paytm, bajaj, crntIssued, crntRecv, startBillNo, endBillNo);

            return sales;
        }

        public static List<DailyCash> GetAllDailyCashRecords()
        {
            List<DailyCash> dailyCashList = new List<DailyCash>();

            using (SqlConnection connection = GetConnection(Home.smServerName, Home.smDBName))
            {
                connection.Open();

                string query = "SELECT * FROM DailyCash ORDER BY Date DESC";
                Debug.WriteLine(query);
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DailyCash dailyCash = new DailyCash
                            {
                                Date = (DateTime)reader["Date"],
                                x500 = (int)reader["x500"],
                                x200 = (int)reader["x200"],
                                x100 = (int)reader["x100"],
                                x50 = (int)reader["x50"],
                                x20 = (int)reader["x20"],
                                x10 = (int)reader["x10"],
                                x5 = (int)reader["x5"],
                                x2 = (int)reader["x2"],
                                x1 = (int)reader["x1"],
                                Submitted = reader["Submitted"] as DateTime?,
                                Emailed = reader["Emailed"] as DateTime?,
                                Verified = reader["Verified"] as DateTime?,
                                Printed = reader["Printed"] as DateTime?,
                                Edited = reader["Edited"] as DateTime?,
                                Initialised = reader["Initialized"] as DateTime?,
                                FirstStart = reader["FirstOpen"] as DateTime?,
                                LastClose = reader["LastClose"] as DateTime?,
                                Deposited = reader["Deposited"] as DateTime?,
                                totalSale = (int)reader["totalSale"],
                                cashSale = (int)reader["cashSale"],
                                cardSale = (int)reader["cardSale"],
                                upiSale = (int)reader["upiSale"],
                                bajajSale = (int)reader["bajajSale"],
                                startBill = reader["startBill"].ToString(),
                                endBill = reader["endBill"].ToString(),
                                debitSale = (int)reader["debitSale"],
                                balReceivedCash = (int)reader["balReceivedCash"],
                                balReceivedCard = (int)reader["balReceivedCard"],
                                crntIssued = (int)reader["crntIssued"],
                                crntReceived = (int)reader["crntReceived"]
                            };

                            dailyCashList.Add(dailyCash);
                        }
                    }
                }
            }

            return dailyCashList;
        }

    }
}
