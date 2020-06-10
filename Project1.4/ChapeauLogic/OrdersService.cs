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
    public class OrdersService
    {
        OrdersDAO orders_db = new OrdersDAO();
        public List<Orders> GetOrders()
        {
            try
            {
                List<Orders> orders = orders_db.GetAllOrdersInfo();
                return orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public List<Orders> GetOrders(string query)
        {
            try
            {
                List<Orders> orders = orders_db.GetAllOrdersInfo(query);
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
