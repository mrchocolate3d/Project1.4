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
    public partial class MenuLunchPage : Form
    {
        public MenuLunchPage()
        {
            InitializeComponent();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuStartPage menustart = new MenuStartPage();
            menustart.ShowDialog();
            this.Close();
        }

        private void btn_L_lunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuLunchPage menulunch = new MenuLunchPage();
            menulunch.ShowDialog();
            this.Close();
        }

        private void btn_L_dinner_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDinnerPage menudinner = new MenuDinnerPage();
            menudinner.ShowDialog();
            this.Close();
        }

        private void btn_L_drinks_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDrinksPage menudrinks = new MenuDrinksPage();
            menudrinks.ShowDialog();
            this.Close();
        }

        private void btn_back_to_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuStartPage menustart = new MenuStartPage();
            menustart.ShowDialog();
            this.Close();
        }

        private void btn_next_to_dinner_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDinnerPage menudinner = new MenuDinnerPage();
            menudinner.ShowDialog();
            this.Close();
        }

        private void btn_to_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuStartPage menustart = new MenuStartPage();
            menustart.ShowDialog();
            this.Close();
        }

        private void btn_to_dinner_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDinnerPage menudinner = new MenuDinnerPage();
            menudinner.ShowDialog();
            this.Close();
        }
    }
}
