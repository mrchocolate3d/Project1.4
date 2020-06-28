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
    public partial class TablePage : Form
    {
        private Employee Employee;
        ChapeauLogic.TableServices tableServices = new ChapeauLogic.TableServices();


        public TablePage(Employee employee)
        {
            InitializeComponent();
            this.Employee = employee;
        }
        private void TablePage_Load(object sender, EventArgs e)
        {
            List<Table> tableList = tableServices.GetTables();
            List<Order> orders = tableServices.GetOrders();
            foreach (Table table in tableList)
            {
                TableStatusCheck(table);
            }
            foreach (Order order in orders)
            {
                UpdateOrder(order);
            }
            lbl_employeeName.Text = Employee.role +": " +Employee.FirstName +" "+ Employee.LastName;
        }
        private void UpdateOrder(Order order)
        {
            List<Label> control = Controls.OfType<Label>().ToList();
            foreach(Label label in control)
            {
                if (int.Parse(label.Tag.ToString()) == order.Table.TableID)
                {
                    label.Show();
                    AssignLabelStatus(order, label);
                    break;
                }
            }
        }

        private void AssignLabelStatus(Order order, Label label)
        {
            if (order.orderComplete == true && order.paidOrders == false)
            {
                label.Text = "Order ready to serve";
            }
            else if (order.orderComplete == false && order.paidOrders == false)
            {
                label.Text = "Order Placed";
            }
        }


        
        private void TableStatusCheck(Table table)
        {
            List<RoundButton> ControlList = Controls.OfType<RoundButton>().OrderBy(x => x.Tag).ToList();
            StatusCheck(table, ControlList[table.TableID - 1]);
        }

        private void StatusCheck(Table table, Button button)
        {
            
            if (table.status == OrderStatus.free.ToString())
            {
                button.BackColor = Color.Green;
            }
            else if (table.status == OrderStatus.reserved.ToString())
            {
                button.BackColor = Color.Yellow;
            }
            else if (table.status == OrderStatus.occupied.ToString())
            {
                button.BackColor = Color.Red;
            }
        }

        private void TableOrder(object sender, EventArgs e)
        {
            List<Table> tableList = tableServices.GetTables();
            foreach(Table table in tableList)
            {
                if( int.Parse(((Button)sender).Text) == table.TableID)
                {
                    NewTableOrder(table);
                    break;
                }
            }
        }
        private void NewTableOrder(Table table)
        {
            ChapeauLogic.OrderService orderService = new ChapeauLogic.OrderService();
            if (table.status == OrderStatus.free.ToString())
            {

                DialogResult dialog = MessageBox.Show("Make Reservation", "Do you want to make a reservation?", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    table.status = OrderStatus.reserved.ToString();
                    orderService.UpdateTable(table);
                    TableStatusCheck(table);
                }
                else
                {
                    this.Hide();
                    MenuStartPage orderSelect = new MenuStartPage(Employee, table);
                    orderSelect.ShowDialog();
                    this.Close();
                }
            }
            else if (table.status == OrderStatus.reserved.ToString())
            {
                DialogResult dialog = MessageBox.Show("Reservation", "Reservation has arrived?", MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    MenuStartPage orderSelect = new MenuStartPage(Employee, table);
                    orderSelect.ShowDialog();
                    this.Close();
                }
                else if (dialog == DialogResult.Cancel)
                {
                    table.status = OrderStatus.free.ToString();
                    orderService.UpdateTable(table);
                    TableStatusCheck(table);
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("View Order", "View", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    this.Hide();
                    Payment viewOrder = new Payment(Employee,table);
                    viewOrder.ShowDialog();
                    this.Close();
                }
            }
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
            this.Close();
        }

    }
}
