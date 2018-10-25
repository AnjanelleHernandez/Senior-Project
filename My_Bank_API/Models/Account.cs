using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Bank_API.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public int UserID { get; set; }
        public int AccountName { get; set; }
        public decimal CurrentTotal { get; set; }
    }
}
