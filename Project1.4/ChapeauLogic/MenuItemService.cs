using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;
using System.Windows.Forms;

namespace ChapeauLogic
{
    public class MenuItemService
    {
        MenuItemsDAO menuItem_db = new MenuItemsDAO();

        public void Update(Order order)
        {
            menuItem_db.UpdateState(order);
        }

        public List<OrderMenuItems> GetMenuItems(int orderno)
        {
            try
            {
                List<OrderMenuItems> order = menuItem_db.db_Get_MenuItems(orderno);
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
