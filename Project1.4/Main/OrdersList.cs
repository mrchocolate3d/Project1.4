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
        OrderMenuItemService details = new OrderMenuItemService();
        Order ord = new Order();

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
            btnOngoing.BackColor = Color.Orange;
            btnComplete.BackColor = Color.BurlyWood;
            Enable_Buttons();
            listOrdr.Items.Clear();
            lblWaitr.Text = "Waiter: ";
            lblTableNr.Text = "__";
            lblOrdr.Text = "Order #";
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
            btnOngoing.BackColor = Color.BurlyWood;
            btnComplete.BackColor = Color.Orange;
            Disable_Buttons();
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

                ord.OrderID = order.OrderID;

                lblWaitr.Text = "Waiter: " + employee.FirstName;
                lblTableNr.Text = order.Table.TableID.ToString();
                lblOrdr.Text = "Order #" + order.OrderID.ToString();

                List<OrderMenuItem> detail = details.GetMenuItems(order.OrderID);

                listOrdr.Items.Clear();
                foreach (OrderMenuItem om in detail)
                {
                    ListViewItem li = new ListViewItem(om.itemName);
                    li.SubItems.Add(om.quantity.ToString());
                    li.SubItems.Add(om.comments);
                    listOrdr.Items.Add(li);
                }
            }

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            details.Update(ord);
            listOrdr.Items.Clear();
            ord.OrderID = 0;
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            List<OrderMenuItem> detail = details.GetMenuItemsDishes(ord.OrderID);

            listOrdr.Items.Clear();
            foreach (OrderMenuItem om in detail)
            {
                ListViewItem li = new ListViewItem(om.itemName);
                li.SubItems.Add(om.quantity.ToString());
                li.SubItems.Add(om.comments);
                listOrdr.Items.Add(li);
            }
            btnKitchen.BackColor = Color.Orange;
            btnBar.BackColor = Color.BurlyWood;
        }

        private void btnBar_Click(object sender, EventArgs e)
        {

            List<OrderMenuItem> detail = details.GetMenuItemsDrinks(ord.OrderID);

            listOrdr.Items.Clear();
            foreach (OrderMenuItem om in detail)
            {
                ListViewItem li = new ListViewItem(om.itemName);
                li.SubItems.Add(om.quantity.ToString());
                li.SubItems.Add(om.comments);
                listOrdr.Items.Add(li);
            }
            btnBar.BackColor = Color.Orange;
            btnKitchen.BackColor = Color.BurlyWood;
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
            this.Close();
        }

        private void Disable_Buttons()
        {
            btnKitchen.BackColor = Color.LightGray;
            btnKitchen.Enabled = false;
            btnBar.BackColor = Color.LightGray;
            btnBar.Enabled = false;
            btnDone.BackColor = Color.LightGreen;
            btnDone.Enabled = false;
        }

        private void Enable_Buttons()
        {
            btnKitchen.Enabled = true;
            btnKitchen.BackColor = Color.BurlyWood;
            btnBar.Enabled = true;
            btnBar.BackColor = Color.BurlyWood;
            btnDone.Enabled = true;
            btnDone.BackColor = Color.YellowGreen;
        }
    }
}
