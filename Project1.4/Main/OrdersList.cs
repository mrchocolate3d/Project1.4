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
        private Timer timer1;

        public OrdersList(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            PrintOrders(false);
            InitTimer();
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
            PrintOrders(false);
        }
        private void btnOngoing_Click(object sender, EventArgs e)
        {
            InitTimer();
            PrintOrders(false);

        }

        void PrintOrders(bool comp)
        {
            OrdersListService ordersService = new OrdersListService();
            List<ChapeauModel.OrdersList> ordersList = ordersService.GetOrders(comp);

            listOrders.Items.Clear();

            foreach (ChapeauModel.OrdersList o in ordersList)
            {
                ListViewItem li = new ListViewItem(o.tableID.TableID.ToString());
                li.SubItems.Add(o.orderID.ToString());
                listOrders.Items.Add(li);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            PrintOrders(true);
        }

        private void listOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOrders.SelectedItems.Count > 0)
            {
                ListViewItem item = listOrders.SelectedItems[0];
                Order order = new Order()
                {
                    Table = new Table(int.Parse(item.SubItems[0].Text)),
                    OrderID = int.Parse(item.SubItems[1].Text)
                };
                this.Hide();
                OrderView OrderPage = new OrderView(employee, order);
                OrderPage.ShowDialog();
                this.Close();
            }

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
            this.Close();
        }
    }
}
