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
            ViewOrder(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
        }

        void ViewOrder(int orderno)
        {
            lblTable.Text = "Table #2";
            lblOrder.Text = "Order #2";
            lblWaiter.Text = "Waiter: Seyifunmi";

            MenuItemService details = new MenuItemService();
            List<OrderMenuItems> detail = details.GetMenuItems(orderno);

            listOrder.Items.Clear();
            foreach(OrderMenuItems om in detail)
            {
                ListViewItem li = new ListViewItem(om.itemName);
                li.SubItems.Add(om.quantity.ToString());
                listOrder.Items.Add(li);
            }
        }
    }
}
