using Sales_Management.Properties;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Sales_Management
{
    public partial class Home : Form
    {
        /*
        public static string posDBName = "GRetail_JUNIOR";
        public static string posServerName = "JUNIOR\\SQLEXPRESS";
        public static string smDBName = "SalesManagement";
        public static string smServerName = "JUNIOR\\SQLEXPRESS";
        public static string posUserName = "cl_admin";
        public static string posPwd = "Tph@2015";
        public static string smUserName = "";
        public static string smPwd = "";
        public static string paytmId = "149545";
        public static string bajajId = "149546";*/

        public static string posDBName;
        public static string posServerName;
        public static string smDBName;
        public static string smServerName;
        public static string posUserName;
        public static string posPwd;
        public static string smUserName;
        public static string smPwd;
        public static string paytmId;
        public static string bajajId;

        public static string directory = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);


        public static DailyCash cashDetails = new DailyCash();
        public static SaleParameters saleParameters;

        public static string currentDate = "";

        public void InitializeAppConfig()
        {
            posDBName = ConfigurationManager.AppSettings["PosDBName"];
            posServerName = ConfigurationManager.AppSettings["PosServerName"];
            smDBName = ConfigurationManager.AppSettings["SmDBName"];
            smServerName = ConfigurationManager.AppSettings["SmServerName"];
            posUserName = ConfigurationManager.AppSettings["PosUserName"];
            posPwd = ConfigurationManager.AppSettings["PosPwd"];
            smUserName = ConfigurationManager.AppSettings["SmUserName"];
            smPwd = ConfigurationManager.AppSettings["SmPwd"];
            paytmId = ConfigurationManager.AppSettings["PaytmId"];
            bajajId = ConfigurationManager.AppSettings["BajajId"];

            directory = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        }

        public Home()
        {
            InitializeAppConfig();

            InitializeComponent();
        }

        public void SetSalesParameters(string date)
        {
            saleParameters = DBHandler.GetDailySales(posServerName, posDBName, date);

            cashDetails.totalSale = saleParameters.totSale;
            cashDetails.cashSale = saleParameters.cashSale;
            cashDetails.cardSale = saleParameters.cardSale;
            cashDetails.upiSale = saleParameters.paytm;
            cashDetails.bajajSale = saleParameters.bajaj;
            cashDetails.debitSale = saleParameters.debitSale;
            cashDetails.balReceivedCash = saleParameters.balReceived_cash;
            cashDetails.balReceivedCard = saleParameters.balReceived_card;
            cashDetails.crntIssued = saleParameters.crntIssued;
            cashDetails.crntReceived = saleParameters.crntRecv;
            cashDetails.startBill = saleParameters.startBillNo;
            cashDetails.endBill = saleParameters.endBillNo;

            totalSaleTextBox.Text = saleParameters.getTotSale().ToString();
            cashSaleTextBox.Text = saleParameters.getCashSale().ToString();
            cardSaleTextBox.Text = (saleParameters.getCardSale().ToString());
            upiSaleTextBox.Text = saleParameters.getPaytm().ToString();
            bajajSaleTextBox.Text = saleParameters.getBajaj().ToString();
            debitSaleTextBox.Text = saleParameters.getBajaj().ToString();
            balanceCashTextBox.Text = saleParameters.getBalReceivedCash().ToString();
            balanceCardTextBox.Text = saleParameters.getBalReceivedCard().ToString();
            crntReceivedTextBox.Text = saleParameters.getCrntRecv().ToString();
            crntIssuedTextBox.Text = saleParameters.getCrntIssued().ToString();
            startBillTextBox.Text = saleParameters.getStartBillNo().ToString();
            endBillTextBox.Text = saleParameters.getEndBillNo().ToString();
        }

        public int GetGridTotal(DataGridView dataGrid, int columnIndex)
        {
            int sum = 0;

            try
            {
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    // Check if the cell value is numeric
                    if (row.Cells[columnIndex].Value != null && int.TryParse(row.Cells[columnIndex].Value.ToString(), out int cellValue))
                    {
                        sum += cellValue;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error calculating sum: {ex.Message}");
            }

            return sum;
        }

        public void UpdateTotals()
        {
            int sum = 0;

            sum = GetGridTotal(creditDataGrid, 1);
            totalCredits.Text = sum.ToString();

            sum = GetGridTotal(debitDataGrid, 1);
            totalDebits.Text = sum.ToString();

            sum = GetGridTotal(cashDetailsDataGrid, 2);
            availableCashLabel.Text = sum.ToString();
        }

        public void UpdateCalculatedCash()
        {
            //cal
            int cashSale = 0;
            int balanceReceived = 0;
            int totCredits = 0;
            int totDebits = 0;

            int.TryParse(cashSaleTextBox.Text.ToString(), out cashSale);
            int.TryParse(balanceCashTextBox.Text.ToString(), out balanceReceived);
            int.TryParse(totalCredits.Text.ToString(), out totCredits);
            int.TryParse(totalDebits.Text.ToString(), out totDebits);

            int calculatedCash = cashSale + totCredits + balanceReceived - totDebits;

            calculatedCashLabel.Text = calculatedCash.ToString();

            int difference = int.Parse(availableCashLabel.Text.ToString()) - calculatedCash;
            differenceLabel.Text = difference.ToString();

            if (difference < 0) differenceLabel.ForeColor = Color.Red;

            else if (difference > 0) differenceLabel.ForeColor = Color.Blue;

            else differenceLabel.ForeColor = Color.Green;

        }

        private void DeleteRowFromDataGrid(DataGridView dataGrid, int rowIndex)
        {
            dataGrid.Rows.RemoveAt(rowIndex);

        }

        private void InitializeDataGrid(DataGridView dataGridView)
        {
            // Clear existing columns, if any
            dataGridView.Columns.Clear();

            dataGridView.RowHeadersVisible = false;

            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // Create "Particulars" column
            DataGridViewTextBoxColumn particularsColumn = new DataGridViewTextBoxColumn();
            particularsColumn.Name = "Particulars";
            particularsColumn.HeaderText = "Particulars";
            dataGridView.Columns.Add(particularsColumn);

            // Create "Amount" column
            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.Name = "Amount";
            amountColumn.HeaderText = "Amount";
            dataGridView.Columns.Add(amountColumn);

            // Set up "Amount" column to only accept numeric input
            DataGridViewCell cellTemplate = new DataGridViewTextBoxCell();
            cellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewColumn amountColumnRef = dataGridView.Columns["Amount"];
            amountColumnRef.CellTemplate = cellTemplate;
            amountColumnRef.DefaultCellStyle.Format = "N2"; // Optional formatting for numeric values

            // Handle the CellValidating event to restrict input to numeric values
            /*dataGridView.CellValidating += (sender, e) =>
            {
                if (e.ColumnIndex == dataGridView.Columns["Amount"].Index)
                {
                    if (!double.TryParse(e.FormattedValue.ToString(), out _))
                    {
                        

                    }
                }
            };*/

            // Handle the CellValidated event to delete the row upon validation error
            dataGridView.CellValidated += (sender, e) =>
            {
                if (e.ColumnIndex == dataGridView.Columns["Amount"].Index)
                {
                    if (!double.TryParse(dataGridView[e.ColumnIndex, e.RowIndex].FormattedValue.ToString(), out _))
                    {
                        // Delete the current row upon validation error
                        if (dataGridView.Rows.Count > 0)
                        {
                            MessageBox.Show("Please enter a numeric value for the Amount column.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            int rowIndex = e.RowIndex;
                            dataGridView.Rows.RemoveAt(rowIndex);
                        }
                    }
                }
            };

        }

        public void PopulateDataGrid(DataGridView dataGridView, string date = "")
        {
            string type = "";

            if (dataGridView.Name.Contains("credit"))
            {
                type = "CR";
            }

            else if (dataGridView.Name.Contains("debit"))
            {
                type = "DR";
            }

            if (date == "")
            {
                date = DateTime.Now.ToString("yyyy/MM/dd");
            }

            DataTable dt = DBHandler.GetDailyTransactions(date, type);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dataGridView.Rows.Add(row["Particular"].ToString(), row["Amount"].ToString());
                }
            }
        }

        public void InitializeCashGrid()
        {
            // Create "Denomination" column
            DataGridViewTextBoxColumn denominationColumn = new DataGridViewTextBoxColumn();
            denominationColumn.Name = "Denomination";
            denominationColumn.HeaderText = "Denomination";
            cashDetailsDataGrid.Columns.Add(denominationColumn);

            // Create "Qty" column
            DataGridViewTextBoxColumn qtyColumn = new DataGridViewTextBoxColumn();
            qtyColumn.Name = "Qty";
            qtyColumn.HeaderText = "Qty";
            qtyColumn.ReadOnly = false; // Allow editing in the "Qty" column
            cashDetailsDataGrid.Columns.Add(qtyColumn);

            // Create "Amount" column
            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.Name = "Amount";
            amountColumn.HeaderText = "Amount";
            amountColumn.ReadOnly = true; // Make "Amount" column read-only
            cashDetailsDataGrid.Columns.Add(amountColumn);

            //DataTable dataTable = DBHandler.GetDailyCash(DateTime.Now.ToString("yyyy/MM/dd"));
            cashDetails = DBHandler.GetDailyCash(DateTime.Now.ToString("yyyy/MM/dd"));

            if (cashDetails != null)
            {
                cashDetailsDataGrid.Rows.Add("500", cashDetails.x500, cashDetails.x500 * 500);
                cashDetailsDataGrid.Rows.Add("200", cashDetails.x200, cashDetails.x200 * 200);
                cashDetailsDataGrid.Rows.Add("100", cashDetails.x100, cashDetails.x100 * 100);
                cashDetailsDataGrid.Rows.Add("50", cashDetails.x50, cashDetails.x50 * 50);
                cashDetailsDataGrid.Rows.Add("20", cashDetails.x20, cashDetails.x20 * 20);
                cashDetailsDataGrid.Rows.Add("10", cashDetails.x10, cashDetails.x10 * 10);
                cashDetailsDataGrid.Rows.Add("5", cashDetails.x5, cashDetails.x5 * 5);
                cashDetailsDataGrid.Rows.Add("2", cashDetails.x2, cashDetails.x2 * 2);
                cashDetailsDataGrid.Rows.Add("1", cashDetails.x1, cashDetails.x1 * 1);


            }
        }

        public int GetOpeningCash()
        {
            int opCash = -1;

            OpeningCash openingCash = new OpeningCash();
            if (openingCash.ShowDialog() == DialogResult.OK)
            {
                openingCash.Close();
                int.TryParse(openingCash.opCashTextBox.Text.ToString(), out opCash);

                if (opCash > 0)
                {
                    int success = DBHandler.UpdateQuery("DailyCash", $"Initialized = '{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}'", $"Date = '{DateTime.Now.ToString("yyyy/MM/dd")}'");
                    if (success == 1)
                    {
                        DBHandler.AddDailyTransaction(DateTime.Today.ToString("yyyy/MM/dd"), "CR", "Opening Cash", opCash);
                        cashDetails.Initialised = DateTime.Now;
                    }
                    else opCash = -1;
                }
            }

            return opCash;
        }

        public void InitializeDay()
        {
            //string initialized = "";

            //DataTable dataTable = DBHandler.GetDailyCash(DateTime.Now.ToString("yyyy/MM/dd"));
            cashDetails = DBHandler.GetDailyCash(DateTime.Now.ToString("yyyy/MM/dd"));


            //Opened for first time in the day
            if (cashDetails == null)
            {
                int added = DBHandler.InsertNewDay();
                if (added == 1)
                {
                    cashDetails = DBHandler.GetDailyCash(DateTime.Now.ToString("yyyy/MM/dd"));

                    MessageBox.Show("New Day Created!");
                    int opCash = GetOpeningCash();
                    //creditDataGrid.Rows.Add("Opening Cash", opCash);
                }
            }

            //Day already created
            else
            {
                //Day Created but not initialized
                //if (dataTable.Rows[0]["Initialized"].ToString().Length == 0)
                if (cashDetails.Initialised.Equals(null))
                {
                    int opCash = GetOpeningCash();

                }
            }

        }

        public void UpdateSalesParametersToDB(string date)
        {
            int success = DBHandler.UpdateQuery("DailyCash",
                $"totalSale = '{cashDetails.totalSale}'," +
                $"cashSale = '{cashDetails.cashSale}'," +
                $"cardSale = '{cashDetails.cardSale}'," +
                $"upiSale = '{cashDetails.upiSale}'," +
                $"bajajSale = '{cashDetails.bajajSale}'," +
                $"debitSale = '{cashDetails.debitSale}'," +
                $"balReceivedCash = '{cashDetails.balReceivedCash}'," +
                $"balReceivedCard = '{cashDetails.balReceivedCard}'," +
                $"crntIssued = '{cashDetails.crntIssued}'," +
                $"crntReceived = '{cashDetails.crntReceived}'," +
                $"startBill = '{cashDetails.startBill}', " +
                $"endBill = '{cashDetails.endBill}' ",
                $"Date = '{cashDetails.Date.ToString("yyyy-MM-dd")}'");

        }

        private void Home_Load(object sender, EventArgs e)
        {

            InitializeDay();

            InitializeDataGrid(creditDataGrid);
            InitializeDataGrid(debitDataGrid);

            InitializeCashGrid();

            PopulateDataGrid(creditDataGrid);
            PopulateDataGrid(debitDataGrid);

            SetSalesParameters(DateTime.Now.ToString("yyyy/MM/dd"));

            UpdateSalesParametersToDB(DateTime.Now.ToString("yyyy/MM/dd"));

            UpdateTotals();
            UpdateCalculatedCash();


            GetSalesOverview();




            dateLabel.Text = DateTime.Now.ToString("dd-MMM-yyyy");


        }


        private void homeTab_Click(object sender, EventArgs e)
        {

        }

        private void addCreditDebit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string source = button.Name;
            string particular = "";
            int value = 0;
            string type = "";

            DataGridView dataGrid = new DataGridView();
            if (source.Contains("Credit"))
            {
                dataGrid = creditDataGrid;
                particular = creditParticulars.Text.ToString();
                int.TryParse(creditValue.Text.ToString(), out value);
                creditValue.Text = value.ToString();
                type = "CR";

                creditParticulars.Text = "";
                creditValue.Text = "";
            }

            else if (source.Contains("Debit"))
            {
                dataGrid = debitDataGrid;
                particular = debitParticulars.Text.ToString();
                int.TryParse(debitValue.Text.ToString(), out value);
                debitValue.Text = value.ToString();
                type = "DR";

                debitParticulars.Text = "";
                debitValue.Text = "";
            }

            if (value == 0)
            {
                MessageBox.Show("Please Enter number greater than 0 in amount!");
            }

            else
            {
                int success = DBHandler.AddDailyTransaction(dateLabel.Text.ToString(), type, particular, value);
                if (success == 1)
                {
                    dataGrid.Rows.Add(particular, value.ToString());
                    UpdateTotals();
                    UpdateCalculatedCash();
                }

                else MessageBox.Show("Error in adding entry!");
            }

        }

        private void deleteCreditDebit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string source = button.Name;
            string particular = "";
            string value = "";
            string type = "";

            DataGridView dataGrid = new DataGridView();
            int selectedIndex = -1;

            if (source.Contains("Credit"))
            {
                dataGrid = creditDataGrid;
                //particular = creditParticulars.Text.ToString();
                //int.TryParse(creditValue.Text.ToString(), out value);
                //creditValue.Text = value.ToString();
                type = "CR";
            }

            else if (source.Contains("Debit"))
            {
                dataGrid = debitDataGrid;
                //particular = debitParticulars.Text.ToString();
                //int.TryParse(debitValue.Text.ToString(), out value);
                //debitValue.Text = value.ToString();
                type = "DR";
            }

            selectedIndex = dataGrid.SelectedRows[0].Index;


            if (selectedIndex > -1)
            {
                particular = dataGrid.Rows[selectedIndex].Cells["Particulars"].Value.ToString();
                value = dataGrid.Rows[selectedIndex].Cells["Amount"].Value.ToString();

                int success = DBHandler.DeleteFromDailyTransaction(dateLabel.Text.ToString(), type, particular, value);

                if (success == 1)
                {
                    dataGrid.Rows.RemoveAt(selectedIndex);
                    UpdateTotals();
                    UpdateCalculatedCash();
                }
                else MessageBox.Show("Error in deleting the entry!");

            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBHandler.UpdateQuery("DailyCash", $"LastClose = '{DateTime.Now.ToShortTimeString()}'", $"Date = '{DateTime.Now.ToString("yyyy/MM/dd")}'");
        }

        private void cashDetailsDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            int columnIndex = e.ColumnIndex;

            if (columnIndex == 1)
            {
                string denomination = cashDetailsDataGrid.Rows[rowIndex].Cells[0].Value.ToString();
                string qty = cashDetailsDataGrid.Rows[rowIndex].Cells[1].Value.ToString();

                cashDetailsDataGrid.Rows[e.RowIndex].Cells[2].Value = int.Parse(denomination) * int.Parse(qty);

                string amount = cashDetailsDataGrid.Rows[rowIndex].Cells[2].Value.ToString();

                int success = DBHandler.UpdateQuery("DailyCash", $"x{denomination} = '{qty}'", $"date = '{cashDetails.Date.ToString("yyyy/MM/dd")}'");
                if (success == 1) { UpdateTotals(); UpdateCalculatedCash(); }
            }
        }

        private void submitAndPrint_Click(object sender, EventArgs e)
        {
            bool alreadySubmitted = false;

            if (!cashDetails.Submitted.Equals(null)) alreadySubmitted = true;
            //PDFUtilities.CaptureAndPrint(this, "Output.pdf");
            //WriteToExcel.ExportToExcel(saleParameters, creditDataGrid, debitDataGrid);
            int success = ExcelWriter.writeToExcel(this, "YM");

            if (success == 1)
            {
                cashDetails.Printed = DateTime.Now;

                if (alreadySubmitted)
                {
                    cashDetails.Edited = DateTime.Now;
                    DBHandler.UpdateQuery("DailyCash", $"Edited = '{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}', Printed = '{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}'", $"Date = '{DateTime.Today.ToString("yyyy/MM/dd")}'");
                }
                else
                {
                    cashDetails.Submitted = DateTime.Now;
                    DBHandler.UpdateQuery("DailyCash", $"Submitted = '{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}', Printed = '{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}'", $"Date = '{DateTime.Today.ToString("yyyy/MM/dd")}'");
                }


                MessageBox.Show("Daily Balance Submitted Successfully");

                success = 0;

                success = ExcelWriter.sendEmail("sneh.nagrecha@gmail.com", "YM");
                if (success == 1)
                {
                    cashDetails.Emailed = DateTime.Now;
                    DBHandler.UpdateQuery("DailyCash", $"Emailed = '{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}'", $"Date = '{DateTime.Today.ToString("yyyy/MM/dd")}'");
                }
            }
        }

        private void GetSalesOverview()
        {
            List<DailyCash> dailyCashList = DBHandler.GetAllDailyCashRecords();

            foreach (DailyCash daySale in dailyCashList)
            {
                //SaleParameters saleParameters = DBHandler.GetDailySales(posServerName, posDBName, daySale.Date.ToString("yyyy/MM/dd"));
                SingleDayOverview overview = new SingleDayOverview();

                overview.dateLabel.Text = daySale.Date.ToString("dd/MM/yyyy");
                overview.startBillLabel.Text = daySale?.startBill;
                overview.endBillLabel.Text = daySale?.endBill;
                overview.totalSale.Text = daySale.totalSale.ToString();
                overview.cashLabel.Text = daySale.cashSale.ToString();
                overview.cardLabel.Text = daySale?.cardSale.ToString();
                overview.upiLabel.Text = daySale?.upiSale.ToString();
                overview.bajajLabel.Text = daySale?.bajajSale.ToString();

                if (daySale.Submitted.Equals(null)) overview.submittedImage.Image = Resources.Red_Cross;
                else overview.submittedImage.Image = Resources.Green_Check;

                if (daySale.Emailed.Equals(null)) overview.emailedImage.Image = Resources.Red_Cross;
                else overview.emailedImage.Image = Resources.Green_Check;

                if (daySale.Verified.Equals(null)) overview.verifiedImage.Image = Resources.Red_Cross;
                else overview.verifiedImage.Image = Resources.Green_Check;


                flp.Controls.Add(overview);
            }
        }
        private void dailyOverviewTab_Click(object sender, EventArgs e)
        {
            GetSalesOverview();
        }
    }
}
