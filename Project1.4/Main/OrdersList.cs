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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listOrders.Items.Clear();

            OrdersService ordersService = new OrdersService();
            List<Orders> ordersList = ordersService.GetOrders("Select distinct os.orderID from orders as os join Order_MenuItem as om on os.orderID = om.orderID where om.[status] >= 2");

            listOrders.Items.Clear();

            foreach (Orders o in ordersList)
            {
                ListViewItem li = new ListViewItem(o.tableID.ToString());
                li.SubItems.Add(o.orderID.ToString());
            }
        }
    }
}
