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
        public decimal totalLunchPrice = 0;
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

        private void Tot_Calc_Lunch_Click(object sender, EventArgs e)
        {
            //Decimal.Round(Update_Price()).ToString();
            tot_price_lunch.Text = "€" + Update_Price().ToString("0.00");

        }
        private decimal Update_Price()
            {
                if (!string.IsNullOrEmpty(txtL1.Text))
                {
                    totalLunchPrice += (int.Parse(txtL1.Text) * decimal.Parse(lblL1price.Text));
                }
                if (!string.IsNullOrEmpty(txtL2.Text))
                {
                    totalLunchPrice += (int.Parse(txtL2.Text) * decimal.Parse(lblL2price.Text));
                }
                if (!string.IsNullOrEmpty(txtL3.Text))
                {
                    totalLunchPrice += (int.Parse(txtL3.Text) * decimal.Parse(lblL3price.Text));
                }
                if (!string.IsNullOrEmpty(txtL4.Text))
                {
                    totalLunchPrice += (int.Parse(txtL4.Text) * decimal.Parse(lblL4price.Text));
                }
                if (!string.IsNullOrEmpty(txtL5.Text))
                {
                    totalLunchPrice += (int.Parse(txtL5.Text) * decimal.Parse(lblL5price.Text));
                }
                if (!string.IsNullOrEmpty(txtL6.Text))
                {
                    totalLunchPrice += (int.Parse(txtL6.Text) * decimal.Parse(lblL6price.Text));
                }
                if (!string.IsNullOrEmpty(txtL7.Text))
                {
                    totalLunchPrice += (int.Parse(txtL7.Text) * decimal.Parse(lblL7price.Text));
                }
                if (!string.IsNullOrEmpty(txtL8.Text))
                {
                    totalLunchPrice += (int.Parse(txtL8.Text) * decimal.Parse(lblL8price.Text));
                }
                if (!string.IsNullOrEmpty(txtL9.Text))
                {
                    totalLunchPrice += (int.Parse(txtL9.Text) * decimal.Parse(lblL9price.Text));
                }
                if (!string.IsNullOrEmpty(txtL10.Text))
                {
                    totalLunchPrice += (int.Parse(txtL10.Text) * decimal.Parse(lblL9price.Text));
                }
                if (!string.IsNullOrEmpty(txtL11.Text))
                {
                    totalLunchPrice += (int.Parse(txtL11.Text) * decimal.Parse(lblL10price.Text));
                }
                if (!string.IsNullOrEmpty(txtL12.Text))
                {
                    totalLunchPrice += (int.Parse(txtL12.Text) * decimal.Parse(lblL12price.Text));
                }

                return totalLunchPrice;
            }
        }
    }

