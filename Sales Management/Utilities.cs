using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sales_Management
{
    internal class Utilities
    {
        public static String email = "thepanthouseonline@gmail.com";
        //public static String toEmail = "sneh.nagrecha@gmail.com";
        public static String pwd = "vvinbgaabmrpsstl";
        public static int sendEmail(string toEmail, string subject, string body)
        {
           
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(email);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;

                //System.Net.Mail.Attachment attachment;
                //attachment = new System.Net.Mail.Attachment(Home.directory + "\\XLSX\\" + source + DateTime.Now.ToString("ddMMyy") + ".xls");
                //mail.Attachments.Add(attachment);

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
    }
}
