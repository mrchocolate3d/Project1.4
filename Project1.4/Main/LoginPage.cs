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
    public partial class LoginPage : Form
    {
        private string password;
        private int count = 0;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void checkPasswod(string input)
        {
            if(count == 4)
            {

            }
            if(input == "1")
            {
                textBox1.AppendText(input);
                count++;
            }
            if(input == "2")
            {
                textBox1.AppendText(input);
                count++;
            }
            if(input == "3")
            {
                textBox1.AppendText(input);
                count++;
            }
            if (input == "4")
            {
                textBox1.AppendText(input);
                count++;
            }
            if (input == "5")
            {
                textBox1.AppendText(input);
                count++;
            }
            if (input == "6")
            {
                textBox1.AppendText(input);
                count++;
            }
            if (input == "7")
            {
                textBox1.AppendText(input);
                count++;
            }
            if (input == "8")
            {
                textBox1.AppendText(input);
                count++;
            }
            if (input == "9")
            {
                textBox1.AppendText(input);
                count++;
            }
            if (input == "0")
            {
                textBox1.AppendText(input);
                count++;
                
            }

        }

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
    }
}
