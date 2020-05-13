using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class StockItems
    {
        public int StockId;
        public int cateagoryId;
        public double totalprice; // total price for the stock ordered
        public int amount; // checks the amount of stock ordered 
        public string stockname;
        public DateTime timeofarrival;

        public StockItems(int StockId, int cateagoryId, double totalprice, int amount, string stockname, DateTime timeofarrival)
        {
            this.StockId = StockId;
            this.cateagoryId = cateagoryId;
            this.totalprice = totalprice;
            this.amount = amount;
            this.stockname = stockname;
            this.timeofarrival = timeofarrival;
        }
                                    
    }
}
