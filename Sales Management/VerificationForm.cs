using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Management
{
    public partial class VerificationForm : Form
    {
        public string otp = "";

        public VerificationForm(string date)
        {
            InitializeComponent();

            currentDate.Value = DateTime.Parse(date);
        }

        private void cashVerified_CheckedChanged(object sender, EventArgs e)
        {
            if (cashVerified.Checked && cardVerified.Checked && upiVerified.Checked)
            {
                otpButton.Enabled = true;
            }
            else
            {
                otpButton.Enabled = false;
            }
        }

        private void currentDate_ValueChanged(object sender, EventArgs e)
        {
            DailyCash dailyCash = DBHandler.GetDailyCash(currentDate.Value.ToString("yyyy-MM-dd"));

            if (dailyCash != null)
            {
                if (dailyCash.Verified != null)
                {
                    cashVerified.Enabled = false;
                    cardVerified.Enabled = false;
                    upiVerified.Enabled = false;
                    salesmanComboBox.Enabled = false;
                    otpLabel.Text = "Sales already verified!";
                    otpLabel.Visible = true;
                }
                else
                {
                    cashVerified.Enabled = true;
                    cardVerified.Enabled = true;
                    upiVerified.Enabled = true;
                    salesmanComboBox.Enabled = true;
                    otpLabel.Visible = false;
                }

            }
        }

        private void VerificationForm_Load(object sender, EventArgs e)
        {
            otpButton.Enabled = false;
            otpLabel.Visible = false;
            verifyButton.Enabled = false;


        }

        private void otpButton_Click(object sender, EventArgs e)
        {

            Random generator = new Random();
            otp = generator.Next(0, 999999).ToString("D6");

            Utilities.sendEmail("sneh.nagrecha@gmail.com", "OTP for sales verification from Y & M", "Please enter the otp: " + otp + " to verify sale details of " + currentDate.Value.ToShortDateString());

        }

        private void otpTextBox_TextChanged(object sender, EventArgs e)
        {
            if (otpTextBox.Text.Length == 6)
            {
                otpLabel.Visible = true;
                if (otpTextBox.Text.ToString().Equals(otp))
                {
                    otpLabel.Text = "OTP is Correct! Kindly click on verify!";
                    otpLabel.ForeColor = Color.Green;
                    verifyButton.Enabled = true;
                }
                else
                {
                    otpLabel.Text = "Incorrect OTP Entered! Please re-enter!";
                    otpLabel.ForeColor = Color.Red;
                    verifyButton.Enabled = false;
                }
            }

            else otpLabel.Visible = false;
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            int success = DBHandler.UpdateQuery("DailyCash", $"Verified = '{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}'", $"Date = '{currentDate.Value.ToString("yyyy/MM/dd")}'");

            if (success == 1) MessageBox.Show($"Sales verified successfully for {currentDate.Value.ToString("dd-MM-yyyy")} by {salesmanComboBox.Text}!");
        }
    }
}
