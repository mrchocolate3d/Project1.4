using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class OrderView : Form
    {
        public OrderView()
        {
            InitializeComponent();
            //ViewOrder();                                              Still having issues with this at the time of upload

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
        }
        void ViewOrder()
        {
            lblTable.Text = "Table #2";
            lblOrder.Text = "Order #2";
            lblWaiter.Text = "Waiter: Seyifunmi";

            OrderService orderService = new OrderService();
            List<Order> orderList = orderService.GetOrders();

            listOrder.Items.Clear();

            foreach (Order o in orderList)
            {
                ListViewItem li = new ListViewItem(o.TableID.ToString());
                li.SubItems.Add(o.EmployeeID.ToString());
                li.SubItems.Add(o.OrderID.ToString());
                listOrder.Items.Add(li);
            }
        }
    }
}
