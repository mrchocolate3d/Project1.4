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
    public partial class TakingLunchOrder : Form
    {
        public TakingLunchOrder()
        {
            InitializeComponent();
        }
        string name;
        double price;
        double tot;

        private void addItem_lunch_Click(object sender, EventArgs e)
        {
            //Lunch Main

            if(saladeNic.Checked)
            {
                name = "Salade Niçoise";
                int qty = int.Parse(numericUpDown1.Value.ToString());
                price = 9.50;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
             if (frenchOmlette.Checked)
            {
                name = "French Omlette";
                int qty = int.Parse(numericUpDown2.Value.ToString());
                price = 8.00;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
             if (fennelDauph.Checked)
            {
                name = "Fennel Dauphinoise";
                int qty = int.Parse(numericUpDown3.Value.ToString());
                price = 9.50;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
             if (quicheOTD.Checked)
            {
                name = "Quiche of the Day";
                int qty = int.Parse(numericUpDown4.Value.ToString());
                price = 8.50;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }

            // Specials

             if (croqueMON.Checked)
            {
                name = "Croque Monsieur-Toast";
                int qty = int.Parse(numericUpDown5.Value.ToString());
                price = 8.95;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
             if (croqueMAM.Checked)
            {
                name = "Croque Madame-Toast";
                int qty = int.Parse(numericUpDown6.Value.ToString());
                price = 9.50;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
             if (homeSoup.Checked)
            {
                name = "Homemade Soup";
                int qty = int.Parse(numericUpDown7.Value.ToString());
                price = 6.95;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
             if (onionSoup.Checked)
            {
                name = "Onion Soup";
                int qty = int.Parse(numericUpDown8.Value.ToString());
                price = 7.50;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            // Bites

            if (torChips.Checked)
            {
                name = "Tortilla Chips";
                int qty = int.Parse(numericUpDown9.Value.ToString());
                price = 7.50;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (crudToast.Checked)
            {
                name = "Crudités with Olive- Aioli Toast";
                int qty = int.Parse(numericUpDown10.Value.ToString());
                price = 5.95;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (belgPrep.Checked)
            {
                name = "Belgian Préparé";
                int qty = int.Parse(numericUpDown11.Value.ToString());
                price = 5.50;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (bread.Checked)
            {
                name = "Bread";
                int qty = int.Parse(numericUpDown12.Value.ToString());
                price = 4.95;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
        }
    }
}
