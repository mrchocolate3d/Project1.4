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
    public class OrderService
    {
        OrderDAO order_db = new OrderDAO();

        public List<Order> GetOrders()
        {
            try
            {
                List<Order> order = order_db.Db_Get_Order_Info();
                return order;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
