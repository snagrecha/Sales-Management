namespace Sales_Management
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            tabControl = new TabControl();
            homeTab = new TabPage();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            endBillTextBox = new TextBox();
            label20 = new Label();
            startBillTextBox = new TextBox();
            label19 = new Label();
            differenceLabel = new Label();
            calculatedCashLabel = new Label();
            availableCashLabel = new Label();
            label18 = new Label();
            label17 = new Label();
            label15 = new Label();
            totalDebits = new Label();
            label16 = new Label();
            totalCredits = new Label();
            label14 = new Label();
            debitValue = new TextBox();
            debitParticulars = new TextBox();
            creditValue = new TextBox();
            creditParticulars = new TextBox();
            deleteDebit = new Button();
            addDebit = new Button();
            deleteCredit = new Button();
            addCredit = new Button();
            submitAndPrint = new Button();
            label13 = new Label();
            label12 = new Label();
            debitDataGrid = new DataGridView();
            creditDataGrid = new DataGridView();
            label7 = new Label();
            cashDetailsDataGrid = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            crntReceivedTextBox = new TextBox();
            crntIssuedTextBox = new TextBox();
            balanceCardTextBox = new TextBox();
            balanceCashTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            debitSaleTextBox = new TextBox();
            bajajSaleTextBox = new TextBox();
            upiSaleTextBox = new TextBox();
            cardSaleTextBox = new TextBox();
            cashSaleTextBox = new TextBox();
            totalSaleTextBox = new TextBox();
            dailyOverviewTab = new TabPage();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            flp = new FlowLayoutPanel();
            statusStrip1 = new StatusStrip();
            dateLabel = new ToolStripStatusLabel();
            tabControl.SuspendLayout();
            homeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)debitDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)creditDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cashDetailsDataGrid).BeginInit();
            dailyOverviewTab.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(homeTab);
            tabControl.Controls.Add(dailyOverviewTab);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1317, 733);
            tabControl.TabIndex = 0;
            // 
            // homeTab
            // 
            homeTab.BackColor = Color.Bisque;
            homeTab.Controls.Add(pictureBox4);
            homeTab.Controls.Add(pictureBox3);
            homeTab.Controls.Add(pictureBox2);
            homeTab.Controls.Add(pictureBox1);
            homeTab.Controls.Add(endBillTextBox);
            homeTab.Controls.Add(label20);
            homeTab.Controls.Add(startBillTextBox);
            homeTab.Controls.Add(label19);
            homeTab.Controls.Add(differenceLabel);
            homeTab.Controls.Add(calculatedCashLabel);
            homeTab.Controls.Add(availableCashLabel);
            homeTab.Controls.Add(label18);
            homeTab.Controls.Add(label17);
            homeTab.Controls.Add(label15);
            homeTab.Controls.Add(totalDebits);
            homeTab.Controls.Add(label16);
            homeTab.Controls.Add(totalCredits);
            homeTab.Controls.Add(label14);
            homeTab.Controls.Add(debitValue);
            homeTab.Controls.Add(debitParticulars);
            homeTab.Controls.Add(creditValue);
            homeTab.Controls.Add(creditParticulars);
            homeTab.Controls.Add(deleteDebit);
            homeTab.Controls.Add(addDebit);
            homeTab.Controls.Add(deleteCredit);
            homeTab.Controls.Add(addCredit);
            homeTab.Controls.Add(submitAndPrint);
            homeTab.Controls.Add(label13);
            homeTab.Controls.Add(label12);
            homeTab.Controls.Add(debitDataGrid);
            homeTab.Controls.Add(creditDataGrid);
            homeTab.Controls.Add(label7);
            homeTab.Controls.Add(cashDetailsDataGrid);
            homeTab.Controls.Add(label8);
            homeTab.Controls.Add(label9);
            homeTab.Controls.Add(label10);
            homeTab.Controls.Add(label11);
            homeTab.Controls.Add(crntReceivedTextBox);
            homeTab.Controls.Add(crntIssuedTextBox);
            homeTab.Controls.Add(balanceCardTextBox);
            homeTab.Controls.Add(balanceCashTextBox);
            homeTab.Controls.Add(label6);
            homeTab.Controls.Add(label5);
            homeTab.Controls.Add(label4);
            homeTab.Controls.Add(label3);
            homeTab.Controls.Add(label2);
            homeTab.Controls.Add(label1);
            homeTab.Controls.Add(debitSaleTextBox);
            homeTab.Controls.Add(bajajSaleTextBox);
            homeTab.Controls.Add(upiSaleTextBox);
            homeTab.Controls.Add(cardSaleTextBox);
            homeTab.Controls.Add(cashSaleTextBox);
            homeTab.Controls.Add(totalSaleTextBox);
            homeTab.Location = new Point(4, 24);
            homeTab.Name = "homeTab";
            homeTab.Padding = new Padding(3);
            homeTab.Size = new Size(1309, 705);
            homeTab.TabIndex = 0;
            homeTab.Text = "Home";
            homeTab.Click += homeTab_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.bajaj_finserv;
            pictureBox4.Location = new Point(875, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(117, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 54;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.upi_logo;
            pictureBox3.Location = new Point(710, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 53;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cash_logo;
            pictureBox2.Location = new Point(321, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.visa_mastercard;
            pictureBox1.Location = new Point(522, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // endBillTextBox
            // 
            endBillTextBox.Enabled = false;
            endBillTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            endBillTextBox.Location = new Point(1061, 154);
            endBillTextBox.Name = "endBillTextBox";
            endBillTextBox.ReadOnly = true;
            endBillTextBox.Size = new Size(115, 25);
            endBillTextBox.TabIndex = 50;
            endBillTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(1074, 130);
            label20.Name = "label20";
            label20.Size = new Size(95, 21);
            label20.TabIndex = 49;
            label20.Text = "End Bill No";
            // 
            // startBillTextBox
            // 
            startBillTextBox.Enabled = false;
            startBillTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            startBillTextBox.Location = new Point(1061, 51);
            startBillTextBox.Name = "startBillTextBox";
            startBillTextBox.ReadOnly = true;
            startBillTextBox.Size = new Size(115, 25);
            startBillTextBox.TabIndex = 48;
            startBillTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(1067, 27);
            label19.Name = "label19";
            label19.Size = new Size(102, 21);
            label19.TabIndex = 47;
            label19.Text = "Start Bill No";
            // 
            // differenceLabel
            // 
            differenceLabel.AutoSize = true;
            differenceLabel.BackColor = Color.Transparent;
            differenceLabel.CausesValidation = false;
            differenceLabel.FlatStyle = FlatStyle.Flat;
            differenceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            differenceLabel.Location = new Point(734, 616);
            differenceLabel.Name = "differenceLabel";
            differenceLabel.Size = new Size(19, 21);
            differenceLabel.TabIndex = 46;
            differenceLabel.Text = "0";
            differenceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calculatedCashLabel
            // 
            calculatedCashLabel.AutoSize = true;
            calculatedCashLabel.BackColor = Color.Transparent;
            calculatedCashLabel.CausesValidation = false;
            calculatedCashLabel.FlatStyle = FlatStyle.Flat;
            calculatedCashLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            calculatedCashLabel.Location = new Point(734, 588);
            calculatedCashLabel.Name = "calculatedCashLabel";
            calculatedCashLabel.Size = new Size(19, 21);
            calculatedCashLabel.TabIndex = 45;
            calculatedCashLabel.Text = "0";
            calculatedCashLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // availableCashLabel
            // 
            availableCashLabel.AutoSize = true;
            availableCashLabel.BackColor = Color.Transparent;
            availableCashLabel.CausesValidation = false;
            availableCashLabel.FlatStyle = FlatStyle.Flat;
            availableCashLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            availableCashLabel.Location = new Point(734, 560);
            availableCashLabel.Name = "availableCashLabel";
            availableCashLabel.Size = new Size(19, 21);
            availableCashLabel.TabIndex = 44;
            availableCashLabel.Text = "0";
            availableCashLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.CausesValidation = false;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(582, 616);
            label18.Name = "label18";
            label18.Size = new Size(94, 21);
            label18.TabIndex = 43;
            label18.Text = "Difference:";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.CausesValidation = false;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(542, 588);
            label17.Name = "label17";
            label17.Size = new Size(135, 21);
            label17.TabIndex = 42;
            label17.Text = "Calculated Cash:";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.CausesValidation = false;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(551, 560);
            label15.Name = "label15";
            label15.Size = new Size(126, 21);
            label15.TabIndex = 41;
            label15.Text = "Available Cash:";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalDebits
            // 
            totalDebits.AutoSize = true;
            totalDebits.BackColor = Color.Transparent;
            totalDebits.CausesValidation = false;
            totalDebits.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalDebits.Location = new Point(1003, 637);
            totalDebits.Name = "totalDebits";
            totalDebits.Size = new Size(19, 21);
            totalDebits.TabIndex = 40;
            totalDebits.Text = "0";
            totalDebits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.CausesValidation = false;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(940, 637);
            label16.Name = "label16";
            label16.Size = new Size(52, 21);
            label16.TabIndex = 39;
            label16.Text = "Total:";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalCredits
            // 
            totalCredits.AutoSize = true;
            totalCredits.BackColor = Color.Transparent;
            totalCredits.CausesValidation = false;
            totalCredits.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalCredits.Location = new Point(339, 637);
            totalCredits.Name = "totalCredits";
            totalCredits.Size = new Size(19, 21);
            totalCredits.TabIndex = 38;
            totalCredits.Text = "0";
            totalCredits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.CausesValidation = false;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(276, 637);
            label14.Name = "label14";
            label14.Size = new Size(52, 21);
            label14.TabIndex = 37;
            label14.Text = "Total:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // debitValue
            // 
            debitValue.Location = new Point(1001, 562);
            debitValue.Name = "debitValue";
            debitValue.Size = new Size(97, 23);
            debitValue.TabIndex = 36;
            // 
            // debitParticulars
            // 
            debitParticulars.Location = new Point(893, 562);
            debitParticulars.Name = "debitParticulars";
            debitParticulars.Size = new Size(97, 23);
            debitParticulars.TabIndex = 35;
            // 
            // creditValue
            // 
            creditValue.Location = new Point(339, 562);
            creditValue.Name = "creditValue";
            creditValue.Size = new Size(97, 23);
            creditValue.TabIndex = 34;
            // 
            // creditParticulars
            // 
            creditParticulars.Location = new Point(231, 562);
            creditParticulars.Name = "creditParticulars";
            creditParticulars.Size = new Size(97, 23);
            creditParticulars.TabIndex = 33;
            // 
            // deleteDebit
            // 
            deleteDebit.Location = new Point(1001, 591);
            deleteDebit.Name = "deleteDebit";
            deleteDebit.Size = new Size(97, 31);
            deleteDebit.TabIndex = 32;
            deleteDebit.Text = "Delete";
            deleteDebit.UseVisualStyleBackColor = true;
            deleteDebit.Click += deleteCreditDebit_Click;
            // 
            // addDebit
            // 
            addDebit.Location = new Point(893, 591);
            addDebit.Name = "addDebit";
            addDebit.Size = new Size(97, 31);
            addDebit.TabIndex = 31;
            addDebit.Text = "Add";
            addDebit.UseVisualStyleBackColor = true;
            addDebit.Click += addCreditDebit_Click;
            // 
            // deleteCredit
            // 
            deleteCredit.Location = new Point(339, 591);
            deleteCredit.Name = "deleteCredit";
            deleteCredit.Size = new Size(97, 31);
            deleteCredit.TabIndex = 30;
            deleteCredit.Text = "Delete";
            deleteCredit.UseVisualStyleBackColor = true;
            deleteCredit.Click += deleteCreditDebit_Click;
            // 
            // addCredit
            // 
            addCredit.Location = new Point(231, 591);
            addCredit.Name = "addCredit";
            addCredit.Size = new Size(97, 31);
            addCredit.TabIndex = 29;
            addCredit.Text = "Add";
            addCredit.UseVisualStyleBackColor = true;
            addCredit.Click += addCreditDebit_Click;
            // 
            // submitAndPrint
            // 
            submitAndPrint.Location = new Point(621, 668);
            submitAndPrint.Name = "submitAndPrint";
            submitAndPrint.Size = new Size(121, 31);
            submitAndPrint.TabIndex = 28;
            submitAndPrint.Text = "Submit And Print";
            submitAndPrint.UseVisualStyleBackColor = true;
            submitAndPrint.Click += submitAndPrint_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(972, 228);
            label13.Name = "label13";
            label13.Size = new Size(59, 21);
            label13.TabIndex = 26;
            label13.Text = "Debits";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(304, 228);
            label12.Name = "label12";
            label12.Size = new Size(63, 21);
            label12.TabIndex = 25;
            label12.Text = "Credits";
            // 
            // debitDataGrid
            // 
            debitDataGrid.AllowUserToAddRows = false;
            debitDataGrid.AllowUserToDeleteRows = false;
            debitDataGrid.BackgroundColor = Color.White;
            debitDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            debitDataGrid.GridColor = Color.White;
            debitDataGrid.Location = new Point(893, 252);
            debitDataGrid.MultiSelect = false;
            debitDataGrid.Name = "debitDataGrid";
            debitDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            debitDataGrid.Size = new Size(205, 290);
            debitDataGrid.TabIndex = 24;
            // 
            // creditDataGrid
            // 
            creditDataGrid.AllowUserToAddRows = false;
            creditDataGrid.AllowUserToDeleteRows = false;
            creditDataGrid.BackgroundColor = Color.White;
            creditDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            creditDataGrid.GridColor = Color.White;
            creditDataGrid.ImeMode = ImeMode.NoControl;
            creditDataGrid.Location = new Point(231, 252);
            creditDataGrid.MultiSelect = false;
            creditDataGrid.Name = "creditDataGrid";
            creditDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            creditDataGrid.Size = new Size(205, 290);
            creditDataGrid.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(621, 228);
            label7.Name = "label7";
            label7.Size = new Size(103, 21);
            label7.TabIndex = 22;
            label7.Text = "Cash Details";
            // 
            // cashDetailsDataGrid
            // 
            cashDetailsDataGrid.AllowUserToAddRows = false;
            cashDetailsDataGrid.AllowUserToDeleteRows = false;
            cashDetailsDataGrid.BackgroundColor = Color.White;
            cashDetailsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cashDetailsDataGrid.GridColor = Color.White;
            cashDetailsDataGrid.Location = new Point(522, 252);
            cashDetailsDataGrid.Name = "cashDetailsDataGrid";
            cashDetailsDataGrid.RowHeadersVisible = false;
            cashDetailsDataGrid.Size = new Size(303, 290);
            cashDetailsDataGrid.TabIndex = 21;
            cashDetailsDataGrid.CellEndEdit += cashDetailsDataGrid_CellEndEdit;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(863, 130);
            label8.Name = "label8";
            label8.Size = new Size(141, 21);
            label8.TabIndex = 20;
            label8.Text = "Cr Note Received";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(707, 130);
            label9.Name = "label9";
            label9.Size = new Size(120, 21);
            label9.TabIndex = 19;
            label9.Text = "Cr Note Issued";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(515, 130);
            label10.Name = "label10";
            label10.Size = new Size(125, 21);
            label10.TabIndex = 18;
            label10.Text = "Bal Recv (Card)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(316, 130);
            label11.Name = "label11";
            label11.Size = new Size(126, 21);
            label11.TabIndex = 17;
            label11.Text = "Bal Recv (Cash)";
            // 
            // crntReceivedTextBox
            // 
            crntReceivedTextBox.Enabled = false;
            crntReceivedTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            crntReceivedTextBox.Location = new Point(877, 154);
            crntReceivedTextBox.Name = "crntReceivedTextBox";
            crntReceivedTextBox.ReadOnly = true;
            crntReceivedTextBox.Size = new Size(115, 25);
            crntReceivedTextBox.TabIndex = 15;
            crntReceivedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // crntIssuedTextBox
            // 
            crntIssuedTextBox.Enabled = false;
            crntIssuedTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            crntIssuedTextBox.Location = new Point(710, 154);
            crntIssuedTextBox.Name = "crntIssuedTextBox";
            crntIssuedTextBox.ReadOnly = true;
            crntIssuedTextBox.Size = new Size(115, 25);
            crntIssuedTextBox.TabIndex = 14;
            crntIssuedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // balanceCardTextBox
            // 
            balanceCardTextBox.Enabled = false;
            balanceCardTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            balanceCardTextBox.Location = new Point(522, 154);
            balanceCardTextBox.Name = "balanceCardTextBox";
            balanceCardTextBox.ReadOnly = true;
            balanceCardTextBox.Size = new Size(115, 25);
            balanceCardTextBox.TabIndex = 13;
            balanceCardTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // balanceCashTextBox
            // 
            balanceCashTextBox.Enabled = false;
            balanceCashTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            balanceCashTextBox.Location = new Point(321, 154);
            balanceCashTextBox.Name = "balanceCashTextBox";
            balanceCashTextBox.ReadOnly = true;
            balanceCashTextBox.Size = new Size(115, 25);
            balanceCashTextBox.TabIndex = 12;
            balanceCashTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(149, 130);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 11;
            label6.Text = "Debit Sale";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(893, 79);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 10;
            label5.Text = "Bajaj Sale";
            label5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(725, 79);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 9;
            label4.Text = "UPI Sale";
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(542, 79);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 8;
            label3.Text = "Card Sale";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(339, 79);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 7;
            label2.Text = "Cash Sale";
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(149, 27);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 6;
            label1.Text = "Total Sale";
            // 
            // debitSaleTextBox
            // 
            debitSaleTextBox.Enabled = false;
            debitSaleTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            debitSaleTextBox.Location = new Point(134, 154);
            debitSaleTextBox.Name = "debitSaleTextBox";
            debitSaleTextBox.ReadOnly = true;
            debitSaleTextBox.Size = new Size(115, 25);
            debitSaleTextBox.TabIndex = 5;
            debitSaleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // bajajSaleTextBox
            // 
            bajajSaleTextBox.Enabled = false;
            bajajSaleTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bajajSaleTextBox.Location = new Point(877, 51);
            bajajSaleTextBox.Name = "bajajSaleTextBox";
            bajajSaleTextBox.ReadOnly = true;
            bajajSaleTextBox.Size = new Size(115, 25);
            bajajSaleTextBox.TabIndex = 4;
            bajajSaleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // upiSaleTextBox
            // 
            upiSaleTextBox.Enabled = false;
            upiSaleTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            upiSaleTextBox.Location = new Point(710, 51);
            upiSaleTextBox.Name = "upiSaleTextBox";
            upiSaleTextBox.ReadOnly = true;
            upiSaleTextBox.Size = new Size(115, 25);
            upiSaleTextBox.TabIndex = 3;
            upiSaleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // cardSaleTextBox
            // 
            cardSaleTextBox.Enabled = false;
            cardSaleTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cardSaleTextBox.Location = new Point(522, 51);
            cardSaleTextBox.Name = "cardSaleTextBox";
            cardSaleTextBox.ReadOnly = true;
            cardSaleTextBox.Size = new Size(115, 25);
            cardSaleTextBox.TabIndex = 2;
            cardSaleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // cashSaleTextBox
            // 
            cashSaleTextBox.Enabled = false;
            cashSaleTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cashSaleTextBox.Location = new Point(321, 51);
            cashSaleTextBox.Name = "cashSaleTextBox";
            cashSaleTextBox.ReadOnly = true;
            cashSaleTextBox.Size = new Size(115, 25);
            cashSaleTextBox.TabIndex = 1;
            cashSaleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // totalSaleTextBox
            // 
            totalSaleTextBox.Enabled = false;
            totalSaleTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalSaleTextBox.Location = new Point(134, 51);
            totalSaleTextBox.Name = "totalSaleTextBox";
            totalSaleTextBox.ReadOnly = true;
            totalSaleTextBox.Size = new Size(115, 25);
            totalSaleTextBox.TabIndex = 0;
            totalSaleTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // dailyOverviewTab
            // 
            dailyOverviewTab.Controls.Add(label32);
            dailyOverviewTab.Controls.Add(label31);
            dailyOverviewTab.Controls.Add(label30);
            dailyOverviewTab.Controls.Add(label29);
            dailyOverviewTab.Controls.Add(label28);
            dailyOverviewTab.Controls.Add(label27);
            dailyOverviewTab.Controls.Add(label26);
            dailyOverviewTab.Controls.Add(label25);
            dailyOverviewTab.Controls.Add(label24);
            dailyOverviewTab.Controls.Add(label23);
            dailyOverviewTab.Controls.Add(label22);
            dailyOverviewTab.Controls.Add(label21);
            dailyOverviewTab.Controls.Add(flp);
            dailyOverviewTab.Location = new Point(4, 24);
            dailyOverviewTab.Name = "dailyOverviewTab";
            dailyOverviewTab.Padding = new Padding(3);
            dailyOverviewTab.Size = new Size(1309, 705);
            dailyOverviewTab.TabIndex = 1;
            dailyOverviewTab.Text = "Daily Overview";
            dailyOverviewTab.UseVisualStyleBackColor = true;
            dailyOverviewTab.Click += dailyOverviewTab_Click;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label32.Location = new Point(1160, 25);
            label32.Name = "label32";
            label32.Size = new Size(78, 19);
            label32.TabIndex = 12;
            label32.Text = "Deposited";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label31.Location = new Point(1063, 25);
            label31.Name = "label31";
            label31.Size = new Size(61, 19);
            label31.TabIndex = 11;
            label31.Text = "Verified";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label30.Location = new Point(962, 24);
            label30.Name = "label30";
            label30.Size = new Size(63, 19);
            label30.TabIndex = 10;
            label30.Text = "Emailed";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label29.Location = new Point(845, 25);
            label29.Name = "label29";
            label29.Size = new Size(80, 19);
            label29.TabIndex = 9;
            label29.Text = "Submitted";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label28.Location = new Point(658, 25);
            label28.Name = "label28";
            label28.Size = new Size(42, 19);
            label28.TabIndex = 8;
            label28.Text = "Bajaj";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label27.Location = new Point(576, 25);
            label27.Name = "label27";
            label27.Size = new Size(32, 19);
            label27.TabIndex = 7;
            label27.Text = "UPI";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(490, 24);
            label26.Name = "label26";
            label26.Size = new Size(40, 19);
            label26.TabIndex = 6;
            label26.Text = "Card";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label25.Location = new Point(400, 24);
            label25.Name = "label25";
            label25.Size = new Size(40, 19);
            label25.TabIndex = 5;
            label25.Text = "Cash";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(311, 25);
            label24.Name = "label24";
            label24.Size = new Size(43, 19);
            label24.TabIndex = 4;
            label24.Text = "Total";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(486, 5);
            label23.Name = "label23";
            label23.Size = new Size(50, 19);
            label23.TabIndex = 3;
            label23.Text = "SALES";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(180, 25);
            label22.Name = "label22";
            label22.Size = new Size(60, 19);
            label22.TabIndex = 2;
            label22.Text = "Bill Nos";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(57, 25);
            label21.Name = "label21";
            label21.Size = new Size(41, 19);
            label21.TabIndex = 1;
            label21.Text = "Date";
            // 
            // flp
            // 
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Location = new Point(26, 49);
            flp.Name = "flp";
            flp.Size = new Size(1261, 632);
            flp.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            statusStrip1.AutoSize = false;
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Items.AddRange(new ToolStripItem[] { dateLabel });
            statusStrip1.Location = new Point(16, 738);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1313, 22);
            statusStrip1.TabIndex = 27;
            statusStrip1.Text = "statusStrip1";
            // 
            // dateLabel
            // 
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(58, 17);
            dateLabel.Text = "dateLabel";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 769);
            Controls.Add(tabControl);
            Controls.Add(statusStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            Text = "Home";
            FormClosed += Home_FormClosed;
            Load += Home_Load;
            tabControl.ResumeLayout(false);
            homeTab.ResumeLayout(false);
            homeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)debitDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)creditDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)cashDetailsDataGrid).EndInit();
            dailyOverviewTab.ResumeLayout(false);
            dailyOverviewTab.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage homeTab;
        private TabPage dailyOverviewTab;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label7;
        private Label label13;
        private Label label12;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel dateLabel;
        private Button deleteDebit;
        private Button addDebit;
        private Button deleteCredit;
        private Button addCredit;
        private Button submitAndPrint;
        private Label label16;
        private Label label14;
        private Label label15;
        private Label label18;
        private Label label17;
        private Label label20;
        private Label label19;
        public TextBox totalSaleTextBox;
        public TextBox debitSaleTextBox;
        public TextBox bajajSaleTextBox;
        public TextBox upiSaleTextBox;
        public TextBox cardSaleTextBox;
        public TextBox cashSaleTextBox;
        public TextBox crntReceivedTextBox;
        public TextBox crntIssuedTextBox;
        public TextBox balanceCardTextBox;
        public TextBox balanceCashTextBox;
        public DataGridView creditDataGrid;
        public DataGridView cashDetailsDataGrid;
        public DataGridView debitDataGrid;
        public TextBox debitValue;
        public TextBox debitParticulars;
        public TextBox creditValue;
        public TextBox creditParticulars;
        public Label totalDebits;
        public Label totalCredits;
        public Label differenceLabel;
        public Label calculatedCashLabel;
        public Label availableCashLabel;
        public TextBox endBillTextBox;
        public TextBox startBillTextBox;
        private FlowLayoutPanel flp;
        private Label label21;
        private Label label22;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label23;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
    }
}
