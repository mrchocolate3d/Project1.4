using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    class MenuItems
    {
        private int OrderId;
        private int quantity;
        private int price;
        private string comments;

        public MenuItems(int orderid,int quantity,int price,string comments)
        {
            this.OrderId = orderid;
            this.quantity = quantity;
            this.comments = comments;
            this.price = price;
        }

    }
}
