using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string TransactionType { get; set; } = string.Empty;
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public DateTime DateIssued { get; set; }
        public double Amount { get; set; }
    }
}
