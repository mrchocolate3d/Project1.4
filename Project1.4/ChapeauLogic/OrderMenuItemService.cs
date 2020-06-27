﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;
using System.Windows.Forms;

namespace ChapeauLogic
{
    public class OrderMenuItemService
    {
        MenuItemsDAO menuItem_db = new MenuItemsDAO();

        public void Update(Order order)
        {
            menuItem_db.UpdateState(order);
        }

        public List<OrderMenuItem> GetMenuItems(int orderno)
        {
            try
            {
                List<OrderMenuItem> order = menuItem_db.db_Get_MenuItems(orderno);
                return order;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public List<OrderMenuItem> GetMenuItemsDishes(int orderno)
        {
            try
            {
                List<OrderMenuItem> order = menuItem_db.db_Get_MenuItems_Dishes(orderno);
                return order;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public List<OrderMenuItem> GetMenuItemsDrinks(int orderno)
        {
            try
            {
                List<OrderMenuItem> order = menuItem_db.db_Get_MenuItems_Drinks(orderno);
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
