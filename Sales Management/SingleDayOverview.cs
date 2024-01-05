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
    public partial class SingleDayOverview : UserControl
    {
        public SingleDayOverview()
        {
            InitializeComponent();
        }

        private void verifiedImage_DoubleClick(object sender, EventArgs e)
        {
            string date = dateLabel.Text;

            VerificationForm verificationForm = new VerificationForm(date);
            verificationForm.ShowDialog();
        }
    }
}
