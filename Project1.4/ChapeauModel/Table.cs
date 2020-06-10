using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Table
    {
        public int TableID { get; set; }
        public string status { get; set; }
        public Table()
        {

        }
        public Table(int tableID)
        {
            TableID = tableID;
        }

    }
}
