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
        public decimal totalDinnerPrice = 0;

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

        private void Tot_Calc_Dinner_Click(object sender, EventArgs e)
        {
            //Decimal.Round(Update_Price()).ToString();
            tot_price_dinner.Text = (decimal.Parse(txtD1.Text) * decimal.Parse(lblD1price.Text)).ToString("N2");
        }

        private decimal Update_Price()
        {
            if (!string.IsNullOrEmpty(txtD1.Text))
            {
                totalDinnerPrice += (int.Parse(txtD1.Text) * decimal.Parse(lblD1price.Text));
            }
            if (!string.IsNullOrEmpty(txtD2.Text))
            {
                totalDinnerPrice += (int.Parse(txtD2.Text) * decimal.Parse(lblD2price.Text));
            }
            if (!string.IsNullOrEmpty(txtD3.Text))
            {
                totalDinnerPrice += (int.Parse(txtD3.Text) * decimal.Parse(lblD3price.Text));
            }
            if (!string.IsNullOrEmpty(txtD4.Text))
            {
                totalDinnerPrice += (int.Parse(txtD4.Text) * decimal.Parse(lblD4price.Text));
            }
            if (!string.IsNullOrEmpty(txtD5.Text))
            {
                totalDinnerPrice +=  (int.Parse(txtD5.Text) * decimal.Parse(lblD5price.Text));
            }
            if (!string.IsNullOrEmpty(txtD6.Text))
            {
                totalDinnerPrice += (int.Parse(txtD6.Text) * decimal.Parse(lblD6price.Text));
            }
            if (!string.IsNullOrEmpty(txtD7.Text))
            {
                totalDinnerPrice += (int.Parse(txtD7.Text) * decimal.Parse(lblD7price.Text));
            }
            if (!string.IsNullOrEmpty(txtD8.Text))
            {
                totalDinnerPrice += (int.Parse(txtD8.Text) * decimal.Parse(lblD8price.Text));
            }
            if (!string.IsNullOrEmpty(txtD9.Text))
            {
                totalDinnerPrice += (int.Parse(txtD9.Text) * decimal.Parse(lblD9price.Text));
            }
            if (!string.IsNullOrEmpty(txtD10.Text))
            {
                totalDinnerPrice += (int.Parse(txtD10.Text) * decimal.Parse(lblD9price.Text));
            }
            if (!string.IsNullOrEmpty(txtD11.Text))
            {
                totalDinnerPrice += (int.Parse(txtD11.Text) * decimal.Parse(lblD10price.Text));
            }
            if (!string.IsNullOrEmpty(txtD12.Text))
            {
                totalDinnerPrice += (int.Parse(txtD12.Text) * decimal.Parse(lblD12price.Text));
            }
            if (!string.IsNullOrEmpty(txtD13.Text))
            {
                totalDinnerPrice += (int.Parse(txtD13.Text) * decimal.Parse(lblD13price.Text));
            }
            if (!string.IsNullOrEmpty(txtD14.Text))
            {
                totalDinnerPrice += (int.Parse(txtD14.Text) * decimal.Parse(lblD14price.Text));
            }
            if (!string.IsNullOrEmpty(txtD15.Text))
            {
                totalDinnerPrice += (int.Parse(txtD15.Text) * decimal.Parse(lblD15price.Text));
            }
            return totalDinnerPrice;
            
  

        }



        
    }
}
