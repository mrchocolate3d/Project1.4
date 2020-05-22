using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class StockItems
    {
        public int StockId { get; set; }
        public int cateagoryId { get; set; }
        public double totalprice { get; set; } // total price for the stock ordered
        public int amount { get; set; } // checks the amount of stock ordered 
        public string stockname { get; set; }
        public DateTime timeofarrival { get; set; }
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
