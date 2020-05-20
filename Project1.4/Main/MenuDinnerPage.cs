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
        public float totalDinnerPrice = 0;

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
            tot_price_dinner.Text = string.Format("{0:0.00}", Update_Price());
        }

        private float Update_Price()
        {
            if (!string.IsNullOrEmpty(txtD1.Text))
            {
                totalDinnerPrice += (int.Parse(txtD1.Text) * float.Parse(lblD1price.Text));
            }
            if (!string.IsNullOrEmpty(txtD2.Text))
            {
                totalDinnerPrice += (int.Parse(txtD2.Text) * float.Parse(lblD2price.Text));
            }
            if (!string.IsNullOrEmpty(txtD3.Text))
            {
                totalDinnerPrice += (int.Parse(txtD3.Text) * float.Parse(lblD3price.Text));
            }
            if (!string.IsNullOrEmpty(txtD4.Text))
            {
                totalDinnerPrice += (int.Parse(txtD4.Text) * float.Parse(lblD4price.Text));
            }
            if (!string.IsNullOrEmpty(txtD5.Text))
            {
                totalDinnerPrice +=  (int.Parse(txtD5.Text) * float.Parse(lblD5price.Text));
            }
            if (!string.IsNullOrEmpty(txtD6.Text))
            {
                totalDinnerPrice += (int.Parse(txtD6.Text) * float.Parse(lblD6price.Text));
            }
            if (!string.IsNullOrEmpty(txtD7.Text))
            {
                totalDinnerPrice += (int.Parse(txtD7.Text) * float.Parse(lblD7price.Text));
            }
            if (!string.IsNullOrEmpty(txtD8.Text))
            {
                totalDinnerPrice += (int.Parse(txtD8.Text) * float.Parse(lblD8price.Text));
            }
            if (!string.IsNullOrEmpty(txtD9.Text))
            {
                totalDinnerPrice += (int.Parse(txtD9.Text) * float.Parse(lblD9price.Text));
            }
            if (!string.IsNullOrEmpty(txtD10.Text))
            {
                totalDinnerPrice += (int.Parse(txtD10.Text) * float.Parse(lblD9price.Text));
            }
            if (!string.IsNullOrEmpty(txtD11.Text))
            {
                totalDinnerPrice += (int.Parse(txtD11.Text) * float.Parse(lblD10price.Text));
            }
            if (!string.IsNullOrEmpty(txtD12.Text))
            {
                totalDinnerPrice += (int.Parse(txtD12.Text) * float.Parse(lblD12price.Text));
            }
            if (!string.IsNullOrEmpty(txtD13.Text))
            {
                totalDinnerPrice += (int.Parse(txtD13.Text) * float.Parse(lblD13price.Text));
            }
            if (!string.IsNullOrEmpty(txtD14.Text))
            {
                totalDinnerPrice += (int.Parse(txtD14.Text) * float.Parse(lblD14price.Text));
            }
            if (!string.IsNullOrEmpty(txtD15.Text))
            {
                totalDinnerPrice += (int.Parse(txtD15.Text) * float.Parse(lblD15price.Text));
            }
            return totalDinnerPrice;
            
  

        }



        
    }
}
