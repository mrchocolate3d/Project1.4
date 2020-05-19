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
    public partial class MenuDinnerPage : Form
    {
        public MenuDinnerPage()
        {
            InitializeComponent();
        }

        private void btn_drinks_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDrinksPage menu = new MenuDrinksPage();
            menu.ShowDialog();
            this.Close();
        }

        private void btn_lunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuLunchPage menu = new MenuLunchPage();
            menu.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDrinksPage menu = new MenuDrinksPage();
            menu.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuLunchPage menulunch = new MenuLunchPage();
            menulunch.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuStartPage menustart = new MenuStartPage();
            menustart.ShowDialog();
            this.Close();
        }

        private void btn_dinner_Click(object sender, EventArgs e)
        {

        }
    }
}
