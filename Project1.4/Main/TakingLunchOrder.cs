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
            if(saladeNic.Checked)
            {
                name = "Salade Niçoise";
                int qty = int.Parse(numericUpDown1.Value.ToString());
                price = 9.50;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            else if (frenchOmlette.Checked)
            {
                name = "French Omlette";
                int qty = int.Parse(numericUpDown2.Value.ToString());
                price = 8.00;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            else if (fennelDauph.Checked)
            {
                name = "Fennel Dauphinoise";
                int qty = int.Parse(numericUpDown3.Value.ToString());
                price = 9.50;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            else if (quicheOTD.Checked)
            {
                name = "Quiche of the Day";
                int qty = int.Parse(numericUpDown4.Value.ToString());
                price = 8.50;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            else if (fennelDauph.Checked)
            {
                name = "Fennel Dauphinoise";
                int qty = int.Parse(numericUpDown1.Value.ToString());
                price = 8.00;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            else if (fennelDauph.Checked)
            {
                name = "Fennel Dauphinoise";
                int qty = int.Parse(numericUpDown1.Value.ToString());
                price = 8.00;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            else if (fennelDauph.Checked)
            {
                name = "Fennel Dauphinoise";
                int qty = int.Parse(numericUpDown1.Value.ToString());
                price = 8.00;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            else if (fennelDauph.Checked)
            {
                name = "Fennel Dauphinoise";
                int qty = int.Parse(numericUpDown1.Value.ToString());
                price = 8.00;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
        }
    }
}
