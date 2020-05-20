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
    public partial class MenuDrinksPage : Form
    {
        public MenuDrinksPage()
        {
            InitializeComponent();
        }

        private void Menu_start_DR_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuStartPage menustart = new MenuStartPage();
            menustart.ShowDialog();
            this.Close();
        }

        private void btn_DRlunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuLunchPage menulunch = new MenuLunchPage();
            menulunch.ShowDialog();
            this.Close();
        }

        private void btn_DRdinner_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDinnerPage menu = new MenuDinnerPage();
            menu.ShowDialog();
            this.Close();
        }

        private void btn_back_to_DINNER_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDinnerPage menu = new MenuDinnerPage();
            menu.ShowDialog();
            this.Close();
        }

        private void btn_back_toDR_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuLunchPage menu = new MenuLunchPage();
            menu.ShowDialog();
            this.Close();
        }
    }
}
