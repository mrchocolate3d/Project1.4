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
        private string role;
        private const int maxValue = 4;

        public LoginPage()
        {
            InitializeComponent();
            LoginBox.PasswordChar = '*';
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Delete")
            {
                LoginBox.Text = LoginBox.Text.Substring(0, (LoginBox.TextLength - 1));
            }
            else
            {
                checkPasswod(((Button)sender).Text);
            }
            
        }

        private void checkPasswod(string input)
        {
            LoginBox.AppendText(input);
            PinCheck();
        }

        private void PinCheck()
        {
            if (LoginBox.TextLength == maxValue)
            {
                login loginCode = new login(int.Parse(LoginBox.Text));
                Employee employee = CheckLogin(loginCode);
                if (employee != null)
                {
                    if(employee.role == "Waiter")
                    {
                        this.Hide();
                        TablePage tablepage = new TablePage(employee);
                        tablepage.ShowDialog();
                        this.Close(); 
                    }
                    else if(employee.role == "Chef" || employee.role == "Bar")
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

        ChapeauLogic.EmployeeServices employeeServices = new ChapeauLogic.EmployeeServices();
        private Employee employee;
        private Employee CheckLogin(login password)
        {
            employee = employeeServices.GetEmployees(password);
            return employee;
        }
    }
}
