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
        private int password;
        public static int maxValue = 4;

        public LoginPage()
        {
            InitializeComponent();
        }

        #region Keypad button setup  
        private void btn_1_Click(object sender, EventArgs e)
        {
            checkPasswod("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            checkPasswod("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            checkPasswod("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            checkPasswod("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            checkPasswod("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            checkPasswod("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            checkPasswod("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            checkPasswod("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            checkPasswod("9");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            checkPasswod("0");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            checkPasswod("delete");
        }
        #endregion

        private void checkPasswod(string input)
        {
            if(input == "1")
            {
                textBox1.AppendText(input);
            }
            if(input == "2")
            {
                textBox1.AppendText(input);
            }
            if(input == "3")
            {
                textBox1.AppendText(input);
            }
            if (input == "4")
            {
                textBox1.AppendText(input);
            }
            if (input == "5")
            {
                textBox1.AppendText(input);
            }
            if (input == "6")
            {
                textBox1.AppendText(input);
            }
            if (input == "7")
            {
                textBox1.AppendText(input);
            }
            if (input == "8")
            {
                textBox1.AppendText(input);
            }
            if (input == "9")
            {
                textBox1.AppendText(input);
            }
            if (input == "0")
            {
                textBox1.AppendText(input);
                
            }
            if (input == "delete")
            {
                textBox1.Text = textBox1.Text.Substring(0, (textBox1.TextLength - 1));  
            }
            PinCheck();
        }

        private void PinCheck()
        {
            if (textBox1.TextLength == maxValue)
            {
                password = int.Parse(textBox1.Text);
                if (CheckLogin(password) == true)
                {

                    this.Hide();
                    HomePage home = new HomePage();
                    home.ShowDialog();
                    this.Close();
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
            List<login> loginList = loginServices.getLogin();

            foreach (login login in loginList)
            {
                if(password == login.loginCode)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }
        
    }
}
