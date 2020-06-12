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
        Order order;
        MenuItemService details = new MenuItemService();
        private Timer timer1;

        public OrderView(Employee employee,Order order)
        {
            this.employee = employee;
            this.order = order;
            InitializeComponent();
            ViewOrder();
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10000; // in miliseconds
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        void ViewOrder()
        {
            lblTable.Text = order.TableID.TableID.ToString();
            lblOrder.Text = order.OrderID.ToString();
            lblWaiter.Text = employee.FirstName;

            
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
            this.Hide();
            OrdersList OrderPage = new OrdersList(employee);
            OrderPage.ShowDialog();
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            details.Update(order);
            this.Hide();
            OrdersList OrderPage = new OrdersList(employee);
            OrderPage.ShowDialog();
            this.Close();
        }
    }
}
