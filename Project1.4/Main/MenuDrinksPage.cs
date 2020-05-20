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
        public decimal totalDrinksPrice = 0;
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

        private void Tot_Calc_Drinks_Click(object sender, EventArgs e)
        {
            //Decimal.Round(Update_Price()).ToString();
            tot_price_drinks.Text = Update_Price().ToString("0.00");
        }

        private decimal Update_Price()
        {
            if (!string.IsNullOrEmpty(txtDR1.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR1.Text) * decimal.Parse(lblDR1price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR2.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR2.Text) * decimal.Parse(lblDR2price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR3.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR3.Text) * decimal.Parse(lblDR3price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR4.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR4.Text) * decimal.Parse(lblDR4price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR5.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR5.Text) * decimal.Parse(lblDR5price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR6.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR6.Text) * decimal.Parse(lblDR6price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR7.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR7.Text) * decimal.Parse(lblDR7price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR8.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR8.Text) * decimal.Parse(lblDR8price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR9.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR9.Text) * decimal.Parse(lblDR9price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR10.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR10.Text) * decimal.Parse(lblDR9price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR11.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR11.Text) * decimal.Parse(lblDR10price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR12.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR12.Text) * decimal.Parse(lblDR12price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR13.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR13.Text) * decimal.Parse(lblDR13price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR14.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR14.Text) * decimal.Parse(lblDR14price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR15.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR15.Text) * decimal.Parse(lblDR15price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR16.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR16.Text) * decimal.Parse(lblDR16price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR17.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR17.Text) * decimal.Parse(lblDR17price.Text));
            }
            if (!string.IsNullOrEmpty(txtDR18.Text))
            {
                totalDrinksPrice += (int.Parse(txtDR18.Text) * decimal.Parse(lblDR18price.Text));
            }
            return totalDrinksPrice;
        }

    }
}
