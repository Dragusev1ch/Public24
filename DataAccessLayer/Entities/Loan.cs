using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Loan
    {
        public int LoadId { get; set; }
        public Customer Customer { get; set; }
        public Branch Branch { get; set; }
        public double LoanAmount { get; set; }
        public DateTime DateIssue { get; set; }
    }
}
