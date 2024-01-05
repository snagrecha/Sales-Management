namespace Sales_Management
{
    partial class VerificationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            salesmanComboBox = new ComboBox();
            dateTimeLabel = new Label();
            cashVerified = new CheckBox();
            cardVerified = new CheckBox();
            upiVerified = new CheckBox();
            otpButton = new Button();
            otpTextBox = new TextBox();
            otpLabel = new Label();
            verifyButton = new Button();
            currentDate = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // salesmanComboBox
            // 
            salesmanComboBox.FormattingEnabled = true;
            salesmanComboBox.Items.AddRange(new object[] { "Sapna", "Sarvesh", "Neeta", "Vishal", "Mitesh" });
            salesmanComboBox.Location = new Point(133, 52);
            salesmanComboBox.Name = "salesmanComboBox";
            salesmanComboBox.Size = new Size(121, 23);
            salesmanComboBox.TabIndex = 0;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.Location = new Point(29, 284);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(332, 30);
            dateTimeLabel.TabIndex = 1;
            dateTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cashVerified
            // 
            cashVerified.AutoSize = true;
            cashVerified.Location = new Point(29, 98);
            cashVerified.Name = "cashVerified";
            cashVerified.Size = new Size(94, 19);
            cashVerified.TabIndex = 2;
            cashVerified.Text = "Cash Verified";
            cashVerified.UseVisualStyleBackColor = true;
            cashVerified.CheckedChanged += cashVerified_CheckedChanged;
            // 
            // cardVerified
            // 
            cardVerified.AutoSize = true;
            cardVerified.Location = new Point(150, 98);
            cardVerified.Name = "cardVerified";
            cardVerified.Size = new Size(93, 19);
            cardVerified.TabIndex = 3;
            cardVerified.Text = "Card Verified";
            cardVerified.UseVisualStyleBackColor = true;
            cardVerified.CheckedChanged += cashVerified_CheckedChanged;
            // 
            // upiVerified
            // 
            upiVerified.AutoSize = true;
            upiVerified.Location = new Point(275, 98);
            upiVerified.Name = "upiVerified";
            upiVerified.Size = new Size(86, 19);
            upiVerified.TabIndex = 4;
            upiVerified.Text = "UPI Verified";
            upiVerified.UseVisualStyleBackColor = true;
            upiVerified.CheckedChanged += cashVerified_CheckedChanged;
            // 
            // otpButton
            // 
            otpButton.Location = new Point(139, 135);
            otpButton.Name = "otpButton";
            otpButton.Size = new Size(104, 34);
            otpButton.TabIndex = 5;
            otpButton.Text = "Generate OTP";
            otpButton.UseVisualStyleBackColor = true;
            otpButton.Click += otpButton_Click;
            // 
            // otpTextBox
            // 
            otpTextBox.Location = new Point(139, 175);
            otpTextBox.Name = "otpTextBox";
            otpTextBox.PlaceholderText = "Enter OTP";
            otpTextBox.Size = new Size(104, 23);
            otpTextBox.TabIndex = 6;
            otpTextBox.TextAlign = HorizontalAlignment.Center;
            otpTextBox.TextChanged += otpTextBox_TextChanged;
            // 
            // otpLabel
            // 
            otpLabel.Location = new Point(29, 213);
            otpLabel.Name = "otpLabel";
            otpLabel.Size = new Size(332, 18);
            otpLabel.TabIndex = 7;
            otpLabel.Text = "label1";
            otpLabel.TextAlign = ContentAlignment.MiddleCenter;
            otpLabel.Visible = false;
            // 
            // verifyButton
            // 
            verifyButton.Location = new Point(139, 247);
            verifyButton.Name = "verifyButton";
            verifyButton.Size = new Size(104, 34);
            verifyButton.TabIndex = 8;
            verifyButton.Text = "Verify";
            verifyButton.UseVisualStyleBackColor = true;
            verifyButton.Click += verifyButton_Click;
            // 
            // currentDate
            // 
            currentDate.Location = new Point(124, 12);
            currentDate.Name = "currentDate";
            currentDate.Size = new Size(139, 23);
            currentDate.TabIndex = 9;
            currentDate.ValueChanged += currentDate_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(93, 12);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 10;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(269, 12);
            button2.Name = "button2";
            button2.Size = new Size(25, 23);
            button2.TabIndex = 11;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            // 
            // VerificationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 335);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(currentDate);
            Controls.Add(verifyButton);
            Controls.Add(otpLabel);
            Controls.Add(otpTextBox);
            Controls.Add(otpButton);
            Controls.Add(upiVerified);
            Controls.Add(cardVerified);
            Controls.Add(cashVerified);
            Controls.Add(dateTimeLabel);
            Controls.Add(salesmanComboBox);
            Name = "VerificationForm";
            Text = "VerificationForm";
            Load += VerificationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox salesmanComboBox;
        private Label dateTimeLabel;
        private CheckBox cashVerified;
        private CheckBox cardVerified;
        private CheckBox upiVerified;
        private Button otpButton;
        private TextBox otpTextBox;
        private Label otpLabel;
        private Button verifyButton;
        private DateTimePicker currentDate;
        private Button button1;
        private Button button2;
    }
}