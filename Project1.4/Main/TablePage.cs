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
        Employee employee;

        public TablePage(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }
        private void TablePage_Load(object sender, EventArgs e)
        {
            ChapeauLogic.TableServices tableServices = new ChapeauLogic.TableServices();
            List<Table> tableList = tableServices.getTables();
            List<Order> orderStatusList = tableServices.getStatus();
            foreach (Table table in tableList)
            {
                tableStatusCheck(table.TableID, table.status);
            }
            foreach (Order OrderStatus in orderStatusList)
            {
                UpdateStausPage(OrderStatus.TableID.TableID, OrderStatus.orderComplete,OrderStatus.paidOrders);
            }
            lbl_employeeName.Text = employee.FirstName + employee.LastName;
        }

        private void UpdateStausPage(int id, bool orderComplete,bool paidOrders)
        {
            List<Label> control = Controls.OfType<Label>().ToList();
            foreach(Label label in control)
            {
                if (int.Parse(label.Tag.ToString()) == id)
                {
                    label.Show();
                    AssignLabelStatus(orderComplete, paidOrders, label);
                }

            }
            //statusCheck(status, ControlList[tableNumber - 1]);
        }

        private void AssignLabelStatus(bool orderComplete,bool paidOrders, Label label)
        {
            if (orderComplete == true && paidOrders == false)
            {
                label.Text = "Ready";
            }
            else if (orderComplete == false && paidOrders == false)
            {
                label.Text = "Preparing";
            }
            else
            {
                label.Text = "Empty";
            }
        }


        
        private void tableStatusCheck(int tableNumber, string status)
        {
            List<RoundButton> ControlList = Controls.OfType<RoundButton>().OrderBy(x => x.Tag).ToList();
            statusCheck(status, ControlList[tableNumber - 1]);
        }

        private void statusCheck(string status, Button button)
        {
            if (status == "free")
            {
                button.BackColor = Color.Green;
            }
            else if (status == "reserved")
            {
                button.BackColor = Color.Blue;
            }
            else if (status == "occupied")
            {
                button.BackColor = Color.Red;
            }
        }

        private void TableOrder(object sender, EventArgs e)
        {
            newTableOrder((Button)sender);
        }
        private void newTableOrder(Button button)
        {
            if(button.BackColor == Color.Green)
            {
                Table table = new Table(int.Parse(button.Text));
                this.Hide();
                MenuStartPage orderSelect = new MenuStartPage(employee,table);
                orderSelect.ShowDialog();
                this.Close();
            }
            else if (button.BackColor == Color.Blue)
            {
                DialogResult dialog = MessageBox.Show("Reserved Customers have arrived", "Cancel Reservation", MessageBoxButtons.YesNo);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("View Order", "View", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    Table table = new Table(int.Parse(button.Text));
                    this.Hide();
                    Payment viewOrder = new Payment(employee,table);
                    viewOrder.ShowDialog();
                    this.Close();
                }
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
