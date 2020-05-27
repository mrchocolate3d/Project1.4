using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Payment
    {
        public int paymentID { get; set; }
        public int orderID { get; set; }
        public int employeeID { get; set; }
        public DateTime dateorder { get; set; }
        public double vat { get; set; }
        public double TotalPrice { get; set; }

    }
}
