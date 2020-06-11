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
        public int EmployeeID { get; set; }
        public int OrderDate { get; set; }
        public string feedback { get; set; }
        public DateTime dateOrder { get; set; }

    }
}
