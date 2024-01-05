using Microsoft.Office.Interop.Excel;
using Sales_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace Sales_Management
{
    class ExcelWriter
    {
        public static String email = "thepanthouseonline@gmail.com";
        //public static String toEmail = "sneh.nagrecha@gmail.com";
        public static String pwd = "vvinbgaabmrpsstl";

        public static void drawBorder(Range c1, Range c2, _Worksheet worksheet)
        {
            worksheet.get_Range(c1, c2).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
        }

        public static int sendEmail(String toEmail, String source)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(email);
                mail.To.Add(toEmail);
                mail.Subject = "Daily Balance Sheet for " + source + " Dated " + DateTime.Now.ToShortDateString();
                mail.Body = "PFA Daily Balance details for " + source + " Dated " + DateTime.Now.ToString();

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(Home.directory + "\\XLSX\\" + source + DateTime.Now.ToString("ddMMyy") + ".xls");
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(email, pwd);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                //MessageBox.Show("Mail Sent!!!");
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }

        public static int writeToExcel(Home home, String source)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            // see the excel sheet behind the program  
            //app.Visible = true;

            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = (_Worksheet?)workbook.Sheets["Sheet1"];
            worksheet = (_Worksheet?)workbook.ActiveSheet;

            // changing the name of active sheet  
            //worksheet.Name = "Exported from gridview";  

            worksheet.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            
            worksheet.Columns.ColumnWidth = 13;

            //Merge 4 set of cells.
            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 9]].Merge(); //Daily Balance for... line
            worksheet.Range[worksheet.Cells[8, 1], worksheet.Cells[8, 2]].Merge(); //CREDIT cell
            worksheet.Range[worksheet.Cells[8, 4], worksheet.Cells[8, 5]].Merge(); //DEBIT cell
            worksheet.Range[worksheet.Cells[8, 7], worksheet.Cells[8, 9]].Merge(); //TOTAL CASH cell

            //Set font to bold for cells
            
            ((Range)worksheet.Cells[1, 1]).Font.Bold = ((Range)worksheet.Cells[7, 1]).Font.Bold = ((Range)worksheet.Cells[7, 4]).Font.Bold = ((Range)worksheet.Cells[7, 7]).Font.Bold = true;
            ((Range)worksheet.Cells[3, 1]).Font.Bold = ((Range)worksheet.Cells[3, 4]).Font.Bold = ((Range)worksheet.Cells[3, 7]).Font.Bold = true;
            worksheet.Range[worksheet.Cells[3, 1], worksheet.Cells[6, 1]].Font.Bold = true;
            worksheet.Range[worksheet.Cells[3, 4], worksheet.Cells[6, 4]].Font.Bold = true;
            worksheet.Range[worksheet.Cells[3, 7], worksheet.Cells[6, 7]].Font.Bold = true;

            worksheet.Cells[1, 1] = "Daily Balance Sheet for " + DateTime.Now.ToShortDateString() + " (" + DateTime.Now.ToString("HH:mm:ss") + ")";
            ((Range)worksheet.Cells[1, 1]).Font.Size = 16;

            worksheet.Cells[3, 1] = "Total Sale";
            worksheet.Cells[3, 2] = home.totalSaleTextBox.Text;

            worksheet.Cells[4, 1] = "Debit Sale";
            worksheet.Cells[4, 2] = home.debitSaleTextBox.Text;

            worksheet.Cells[5, 1] = "Cr. Note Recv";
            worksheet.Cells[5, 2] = home.crntReceivedTextBox.Text;

            worksheet.Cells[6, 1] = "Start Bill No";
            worksheet.Cells[6, 2] = home.startBillTextBox.Text;

            worksheet.Cells[3, 4] = "Cash Sale";
            worksheet.Cells[3, 5] = home.cashSaleTextBox.Text;

            worksheet.Cells[4, 4] = "Bal Recv (Cash)";
            worksheet.Cells[4, 5] = home.balanceCashTextBox.Text;

            worksheet.Cells[5, 4] = "Cr. Note Issued";
            worksheet.Cells[5, 5] = home.crntIssuedTextBox.Text;

            worksheet.Cells[6, 4] = "End Bill No";
            worksheet.Cells[6, 5] = home.endBillTextBox.Text;

            worksheet.Cells[3, 7] = "Card Sale";
            worksheet.Cells[3, 8] = home.cardSaleTextBox.Text;

            worksheet.Cells[4, 7] = "Bal Recv (Card)";
            worksheet.Cells[4, 8] = home.balanceCardTextBox.Text;

            worksheet.Cells[5, 7] = "PayTm";
            worksheet.Cells[5, 8] = home.upiSaleTextBox.Text;

            worksheet.Cells[6, 7] = "Bajaj";
            worksheet.Cells[6, 8] = home.bajajSaleTextBox.Text;

            worksheet.Cells[8, 1] = "CREDIT";
            worksheet.Cells[8, 4] = "DEBIT";
            worksheet.Cells[8, 7] = "TOTAL CASH";

            int x = 9;
            int y = 1;
            int max = 0;

            for (int j = 0; j < home.creditDataGrid.Columns.Count; j++)
            {
                if (home.creditDataGrid.Rows.Count > max) max = home.creditDataGrid.Rows.Count;

                worksheet.Cells[x, j + y] = home.creditDataGrid.Columns[j].HeaderText;
                ((Range)worksheet.Cells[x, j + y]).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Silver);

                for (int i = 0; i < home.creditDataGrid.Rows.Count; i++)
                {
                    worksheet.Cells[x + i + 1, j + y] = home.creditDataGrid.Rows[i].Cells[j].Value.ToString();
                }
            }

            worksheet.Cells[x + home.creditDataGrid.RowCount + 1, y] = "Total Credit";
            ((Range)worksheet.Cells[x + home.creditDataGrid.RowCount + 1, y]).Font.Bold = true;
            worksheet.Cells[x + home.creditDataGrid.RowCount + 1, y + 1] = home.totalCredits.Text;//Replace with totalCreditLabel text

            y += home.creditDataGrid.Columns.Count + 1;

            for (int j = 0; j < home.debitDataGrid.Columns.Count; j++)
            {
                if (home.debitDataGrid.Rows.Count > max) max = home.debitDataGrid.Rows.Count;
                worksheet.Cells[x, j + y] = home.debitDataGrid.Columns[j].HeaderText;
                ((Range)worksheet.Cells[x, j + y]).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Silver);

                for (int i = 0; i < home.debitDataGrid.Rows.Count; i++)
                {
                    worksheet.Cells[x + i + 1, j + y] = home.debitDataGrid.Rows[i].Cells[j].Value.ToString();
                }
            }

            worksheet.Cells[x + home.debitDataGrid.RowCount + 1, y] = "Total Debit";
            ((Range)worksheet.Cells[x + home.debitDataGrid.RowCount + 1, y]).Font.Bold = true;
            worksheet.Cells[x + home.debitDataGrid.RowCount + 1, y + 1] = home.totalDebits.Text;//Replace with totalDebitLabel text

            y += home.debitDataGrid.Columns.Count + 1;

            for (int j = 0; j < home.cashDetailsDataGrid.Columns.Count; j++)
            {
                if (home.cashDetailsDataGrid.Rows.Count > max) max = home.cashDetailsDataGrid.Rows.Count;
                worksheet.Cells[x, j + y] = home.cashDetailsDataGrid.Columns[j].HeaderText;
                ((Range)worksheet.Cells[x, j + y]).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Silver);

                for (int i = 0; i < home.cashDetailsDataGrid.Rows.Count; i++)
                {
                    worksheet.Cells[x + i + 1, j + y] = home.cashDetailsDataGrid.Rows[i].Cells[j].Value.ToString();
                }
            }

            worksheet.Range[worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 1, y], worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 1, y + 1]].Merge();
            worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 1, y] = "Total Cash";
            //worksheet.Range[worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 1, y]].Font.Bold = true;
            ((Range)worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 1, y]).Font.Bold = true;
            worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 1, y + 2] = home.availableCashLabel.Text;//Replace with totalCashLabel text

            worksheet.Range[worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 2, y], worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 2, y + 1]].Merge();
            worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 2, y] = "Calculated Cash";
            //worksheet.Range[worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 2, y]].Font.Bold = true;
            ((Range)worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 2, y]).Font.Bold = true;
            worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 2, y + 2] = home.calculatedCashLabel.Text;//Replace with totalCashLabel text

            worksheet.Range[worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 3, y], worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 3, y + 1]].Merge();
            worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 3, y] = "Difference";
            ((Range)worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 3, y]).Font.Bold = true;
            worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 3, y + 2] = home.differenceLabel.Text;//Replace with totalCashLabel text


            worksheet.Range[worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 2, 1], worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 2, 6]].Merge();
            worksheet.Cells[x + home.cashDetailsDataGrid.RowCount + 2, 1] = "*Calculated cash = Cash Sale + total credit - total debit";
            /*x = x + max + 2;

            Range c1 = worksheet.Cells[x, 1];
            Range c2 = worksheet.Cells[x + 3, 1];
            worksheet.get_Range(c1, c2).Font.Bold = true;
            
            worksheet.Cells[x, 1] = "Total Credit"; 
            worksheet.Cells[x++, 2] = ""; //Replace with text from TotalCreditLabel

            worksheet.Cells[x, 1] = "Total Debit";
            worksheet.Cells[x++, 2] = ""; //Replace with text from TotalDebitLabel

            worksheet.Cells[x, 1] = "Total Cash Present";
            worksheet.Cells[x++, 2] = ""; //Replace with text from TotalCashLabel

            worksheet.Cells[x, 1] = "Calculated Cash";
            worksheet.Cells[x++, 2] = ""; //Replace with text from BalanceMatch
            */

            //Draw borders around Tables
            drawBorder((Range)worksheet.Cells[x, 1],(Range)worksheet.Cells[x + home.creditDataGrid.RowCount, 2], worksheet);
            drawBorder((Range)worksheet.Cells[x, 4], (Range)worksheet.Cells[x + home.debitDataGrid.RowCount, 5], worksheet);
            drawBorder((Range)worksheet.Cells[x, 7], (Range)worksheet.Cells[x + home.cashDetailsDataGrid.RowCount, 9], worksheet);

            worksheet.PageSetup.Orientation = XlPageOrientation.xlLandscape;
            worksheet.PageSetup.PrintGridlines = true;
            worksheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
            
            //Print the excel sheet
            worksheet.PrintOutEx();

            app.DisplayAlerts = false;
            //app.Visible = true;
            //app.ActiveWindow.PrintPreview();
            // save the application  
            workbook.SaveAs(Home.directory + "\\XLSX\\" + source + DateTime.Now.ToString("ddMMyy") + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            workbook.SaveAs(source + DateTime.Now.ToString("ddMMyy") + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);       // Exit from the application  
            workbook.Close();
            app.Quit();

            return 1;
            //sendEmail("sneh.nagrecha@gmail.com", "Y&M");

        }
    }
}