using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Order
    {
        public int OrderID { get; set; }
        public Table TableID { get; set; }
        public Employee EmployeeID { get; set; }
        public DateTime  OrderDate { get { return DateTime.Now; } }
        public string feedback { get; set; }
        public bool orderComplete { get; set; }
        public bool paidOrders { get; set; }

    }
}
