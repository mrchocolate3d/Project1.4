using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class StockItems
    {
        private int StockId;
        private int cateagoryId;
        private double totalprice; // total price for the stock ordered
        private int amount; // checks the amount of stock ordered 
        private string stockname;
        private DateTime timeofarrival;

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
