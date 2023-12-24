namespace Sales_Management
{
    partial class OpeningCash
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
            opCashTextBox = new TextBox();
            label1 = new Label();
            okButton = new Button();
            SuspendLayout();
            // 
            // opCashTextBox
            // 
            opCashTextBox.Location = new Point(123, 67);
            opCashTextBox.Name = "opCashTextBox";
            opCashTextBox.Size = new Size(100, 23);
            opCashTextBox.TabIndex = 0;
            opCashTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 26);
            label1.Name = "label1";
            label1.Size = new Size(130, 17);
            label1.TabIndex = 1;
            label1.Text = "Enter Opening Cash";
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(137, 113);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // OpeningCash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 148);
            Controls.Add(okButton);
            Controls.Add(label1);
            Controls.Add(opCashTextBox);
            Name = "OpeningCash";
            Text = "OpeningCash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button okButton;
        public TextBox opCashTextBox;
    }
}