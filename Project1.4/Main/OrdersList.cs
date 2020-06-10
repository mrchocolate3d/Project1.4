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

        private void btnOngoing_Click(object sender, EventArgs e)
        {
            PrintOrders();
        }

        void PrintOrders()
        {
            OrdersListService ordersService = new OrdersListService();
            List<ChapeauModel.OrdersList> ordersList = ordersService.GetOrders();

            listOrders.Items.Clear();

            foreach (ChapeauModel.OrdersList o in ordersList)
            {
                ListViewItem li = new ListViewItem(o.tableID.ToString());
                li.SubItems.Add(o.orderID.ToString());
                listOrders.Items.Add(li);
            }
        }
        
        private void btnComplete_Click(object sender, EventArgs e)
        {
            PrintOrders();
        }

        private void listOrders_ItemActivate(object sender, EventArgs e)
        {
            this.Hide();
            OrderView OrderPage = new OrderView();
            OrderPage.ShowDialog();
            this.Close();
        }
    }
}
