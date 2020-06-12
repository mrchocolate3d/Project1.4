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
        private static int maxValue = 4;

        public LoginPage()
        {
            InitializeComponent();
            LoginBox.PasswordChar = '*';
        }

        private void btn_Click(object sender, EventArgs e)
        {
            checkPasswod(((Button)sender).Text);
        }

        private void checkPasswod(string input)
        {
            if (input.ToLower() == "delete")
            {
                
                LoginBox.Text = LoginBox.Text.Substring(0, (LoginBox.TextLength - 1));  
            }
            else
            {
                LoginBox.AppendText(input);
            }
            PinCheck();
        }

        private void PinCheck()
        {
            if (LoginBox.TextLength == maxValue)
            {
                login password = new login(int.Parse(LoginBox.Text));
                if (CheckLogin(password) == true)
                {
                    if(role == "Waiter")
                    {
                        this.Hide();
                        TablePage tablepage = new TablePage(employee);
                        tablepage.ShowDialog();
                        this.Close(); 
                    }
                    else if(role == "Chef" || role == "Bar")
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
        Employee employee;
        private bool CheckLogin(login password)
        {
            bool check = false;

            employee = employeeServices.GetEmployees(password);
            if (employee != null)
            {
                if (password.loginCode == employee.password.loginCode)
                {
                    check = true;
                    role = employee.role;
                }
            }
            return check;


        }


        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
