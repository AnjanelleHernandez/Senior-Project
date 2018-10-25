using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Bank_API.Models
{
    public class TransactionHistory
    {
        public int TransactionHistoryID { get; set; }
        public int AccountID { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDateAndTime { get; set; }
    }
}
