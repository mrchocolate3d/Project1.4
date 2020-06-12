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
        Employee employee;
        Table table;
        public OrdersList(Employee employee, Table table)
        {
            this.employee = employee;
            this.table = table;
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



        private void listOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOrders.SelectedItems.Count > 0)
            {
                ListViewItem item = listOrders.SelectedItems[0];
                 Order order = new Order()
                {
                    OrderID = int.Parse(item.SubItems[1].Text)
                };
                this.Hide();
                OrderView OrderPage = new OrderView(employee, table, order);
                OrderPage.ShowDialog();
                this.Close();
            }

        }
    }
}
