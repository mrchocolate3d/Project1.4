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
    public partial class MenuStartPage : Form
    {
        public MenuStartPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TakingLunchOrder menulunch = new TakingLunchOrder();
            menulunch.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDinnerPage menudinner = new MenuDinnerPage();
            menudinner.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDrinksPage menudrinks = new MenuDrinksPage();
            menudrinks.ShowDialog();
            this.Close();
        }
    }
}
