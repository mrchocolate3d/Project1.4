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

        public static string UserName = "";
        private static string role = "";
        private int password;
        private static int maxValue = 4;

        public LoginPage()
        {
            InitializeComponent();
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
                password = int.Parse(LoginBox.Text);
                if (CheckLogin(password) == true)
                {
                    if(role == "Waiter")
                    {
                        this.Hide();
                        TakingLunchOrder waiterPage = new TakingLunchOrder();
                        waiterPage.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
        }


        private bool CheckLogin(int password)
        {
            bool check = false;
            ChapeauLogic.LoginServices loginServices = new ChapeauLogic.LoginServices();
            List<login> loginList = loginServices.getLogin(password);
            foreach (login login in loginList)
            {
                if(password == login.loginCode)
                {
                    check = true;
                    UserName = login.firstname +" "+ login.lastname;
                    role = login.role;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }
        
        
        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
