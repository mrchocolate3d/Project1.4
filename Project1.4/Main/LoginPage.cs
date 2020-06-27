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

namespace ChapeauUI
{

    public partial class LoginPage : Form
    {
        private const int MaxValue = 4;
        ChapeauLogic.EmployeeServices EmployeeServices = new ChapeauLogic.EmployeeServices();

        public LoginPage()
        {
            InitializeComponent();
            LoginBox.PasswordChar = '*';
        }

        private void Keypad_Btn_Click(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Text;
            if (buttonText == "Delete")
            {
                LoginBox.Text = LoginBox.Text.Substring(0, (LoginBox.TextLength - 1));
            }
            else
            {
                LoginBox.AppendText(buttonText);
                if (LoginBox.TextLength == MaxValue)
                {
                    LoginEmployee();
                }
            }
        }

        private void LoginEmployee()
        {
            login loginCode = new login(int.Parse(LoginBox.Text));
            Employee employee = EmployeeServices.GetEmployee(loginCode);

            if (employee != null)
            {
                if (employee.role == "Waiter")
                {
                    this.Hide();
                    TablePage tablepage = new TablePage(employee);
                    tablepage.ShowDialog();
                    this.Close();
                }
                else if (employee.role == "Chef" || employee.role == "Bar")
                {
                    this.Hide();
                    OrdersList tablepage = new OrdersList(employee);
                    tablepage.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                LoginBox.Text = "";
                MessageBox.Show("Incorrect Password");
            }
        }
    }
}
