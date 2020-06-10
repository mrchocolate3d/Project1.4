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
    public class OrdersListService
    {
        OrdersListDAO orders_db = new OrdersListDAO();
        public List<OrdersList> GetOrders()
        {
            try
            {
                List<OrdersList> orders = orders_db.GetAllOrdersInfo();
                return orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

    }
}