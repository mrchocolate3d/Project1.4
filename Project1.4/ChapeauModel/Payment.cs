using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Payment
    {
        public string itemName { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public int orderID { get; set; }

    }
}
