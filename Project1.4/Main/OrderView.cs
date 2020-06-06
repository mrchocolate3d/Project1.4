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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment reciept = new Payment();
            reciept.Show();
        }
        void ViewOrder()
        {
            OrderService orderService = new OrderService();
            List<Order> orderList = orderService.GetOrders();

            listOrder.Items.Clear();

            foreach (Order o in orderList)
            {
                
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ViewOrder();
        }
    }
}
