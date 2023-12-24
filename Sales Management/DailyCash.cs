using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management
{
    public class DailyCash
    {
            public DateTime Date { get; set; }
            public int x500 { get; set; }
            public int x200 { get; set; }
            public int x100 { get; set; }
            public int x50 { get; set; }
            public int x20 { get; set; }
            public int x10 { get; set; }
            public int x5 { get; set; }
            public int x2 { get; set; }
            public int x1 { get; set; }
            public DateTime? Submitted { get; set; }
            public DateTime? Emailed { get; set; }
            public DateTime? Verified { get; set; }
            public DateTime? Printed { get; set; }
            public DateTime? Edited { get; set; }
            public DateTime? Initialised { get; set; }
            public DateTime? FirstStart { get; set; }
            public DateTime? LastClose { get; set; }
            public DateTime? Deposited { get; set; }
            public int totalSale { get; set; }
        public int cashSale { get; set; }
        public int cardSale { get; set; }
        public int upiSale { get; set; }
        public int bajajSale { get; set; }
        public string startBill { get; set; }
        public string endBill { get; set; }
        public int debitSale { get; set; }
        public int balReceivedCash { get; set; }
        public int balReceivedCard { get; set; }
        public int crntIssued { get; set; }
        public int crntReceived {  get; set; }
            

        
    }
}
