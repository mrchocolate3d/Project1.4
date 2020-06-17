using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;
using System.Windows.Forms;

namespace ChapeauLogic
{
    public class TableServices
    {
        TableDAO table_db = new TableDAO();

        public List<Table> GetTables()
        {
            try
            {
                List<Table> tables = table_db.getAllTables();
                return tables;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public List<Order> GetOrders()
        {
                List<Order> orders = table_db.getOrderStatus();
                return orders;
        }
    }
}
