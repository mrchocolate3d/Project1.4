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

            foreach (Table table in tableList)
            {
                tableStatusCheck(table.TableID, table.status);
            }
            lbl_employeeName.Text = employee.FirstName + employee.LastName;
        }
        
        private void tableStatusCheck(int tableNumber, string status)
        {
            if (tableNumber == 1)
            {
                statusCheck(status, btn_table1);

            }
            if (tableNumber == 2)
            {
                statusCheck(status,btn_table2);
            }
            if (tableNumber == 3)
            {
                statusCheck(status, btn_table3);
            }
            if (tableNumber == 4)
            {
                statusCheck(status, btn_table4);
            }
            if (tableNumber == 5)
            {
                statusCheck(status, btn_table5);
            }
            if (tableNumber == 6)
            {
                statusCheck(status, btn_table6);
            }
            if (tableNumber == 7)
            {
                statusCheck(status, btn_table7);
            }
            if (tableNumber == 8)
            {
                statusCheck(status, btn_table8);
            }
            if (tableNumber == 9)
            {
                statusCheck(status, btn_table9);
            }
            if (tableNumber == 10)
            {
                statusCheck(status, btn_table10);
            }
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
            // newTableOrder(int.Parse(((Button)sender).Text));
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
                
            }
            else
            {
                
            }
        }
    }
}
