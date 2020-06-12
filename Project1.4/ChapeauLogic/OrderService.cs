﻿using System;
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
        
        public OrderMenuItems getItem(string name)
        {
            OrderMenuItems item = order_db.getNewOrderInfo(name);
            return item;
        }

        public Order getId(Table table,Employee employee)
        {
            Order orderId = order_db.GetOrderID(table,employee);
            return orderId;
        }

        public void NewOrder(Table table, Employee employee)
        {
            try
            {
                order_db.NewOrder(table,employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertMenu(OrderMenuItems items , int id)
        {
            order_db.InsertMenuItem(items,id);
        }

        public void UpdateTable(Table table)
        {
            order_db.UpdateTabe(table);
        }
    }
}
