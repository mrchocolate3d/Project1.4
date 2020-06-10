using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;


namespace ChapeauUI
{
    public partial class OrdersList : Form
    {
        public OrdersList()
        {
            InitializeComponent();
            PrintOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintOrders("Select distinct os.orderID from orders as os join Order_MenuItem as om on os.orderID = om.orderID where om.[status] >= 2");
        }

        void PrintOrders()
        {
            OrdersService ordersService = new OrdersService();
            List<Orders> ordersList = ordersService.GetOrders();

            listOrders.Items.Clear();

            foreach (Orders o in ordersList)
            {
                ListViewItem li = new ListViewItem(o.tableID.ToString());
                li.SubItems.Add(o.orderID.ToString());
                listOrders.Items.Add(li);
            }
        }
        void PrintOrders(string query)
        {
            OrdersService ordersService = new OrdersService();
            List<Orders> ordersList = ordersService.GetOrders(query);

            listOrders.Items.Clear();

            foreach (Orders o in ordersList)
            {
                ListViewItem li = new ListViewItem(o.tableID.ToString());
                li.SubItems.Add(o.orderID.ToString());
                listOrders.Items.Add(li);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintOrders("Select distinct os.orderID from orders as os join Order_MenuItem as om on os.orderID = om.orderID where om.[status] = 3");
        }
    }
}
