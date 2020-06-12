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
        Employee employee;
        Table table;
        Order order;
        public OrderView(Employee employee,Table table, Order order)
        {
            this.employee = employee;
            this.table = table;
            this.order = order;
            InitializeComponent();
            ViewOrder(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment(employee,table);
            payment.Show();
        }

        void ViewOrder(int orderno)
        {
            lblTable.Text = table.TableID.ToString();
            //lblOrder.Text = "Order #2";
            lblWaiter.Text = employee.FirstName;

            MenuItemService details = new MenuItemService();
            List<OrderMenuItems> detail = details.GetMenuItems(order.OrderID);

            listOrder.Items.Clear();
            foreach (OrderMenuItems om in detail)
            {
                ListViewItem li = new ListViewItem(om.itemName);
                li.SubItems.Add(om.quantity.ToString());
                listOrder.Items.Add(li);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
