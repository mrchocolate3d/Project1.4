using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class MenuItems
    {
        public int OrderId;
        public int quantity;
        public int price;
        public string comments;

        public MenuItems(int orderid,int quantity,int price,string comments)
        {
            this.OrderId = orderid;
            this.quantity = quantity;
            this.comments = comments;
            this.price = price;
        }

    }
}
