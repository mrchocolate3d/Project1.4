using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Payment
    {
        public int paymentID;
        public int orderID;
        public int employeeID;
        public int paymentMethod;
        public int dateOrder;
        public int Vat;
        public int Tip;
        public int totalPrice;
    }
}
