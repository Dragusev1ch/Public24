using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Account
    {
        public int AccountID { get; set; }
        public Customer Customer { get; set; }
        public double Balance { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }

    }
}
