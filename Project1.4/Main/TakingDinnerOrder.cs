﻿using System;
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
    public partial class TakingDinnerOrder : Form
    {
        List<NumericUpDown> x = new List<NumericUpDown>();
        public TakingDinnerOrder()
        {
            InitializeComponent();
        }

        private void AddItem_lunch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (NumericUpDown item in x)
            {
                dataGridView1.Rows.Add(item.Name, item.Value);
            }
        }

        private void FoodCount(object sender, EventArgs e)
        {
            CheckAmount(((NumericUpDown)sender));
        }

        private void CheckAmount(NumericUpDown lunch)
        {
            if (lunch.Value >= 1 && !(x.Contains(lunch)))
            {
                x.Add(lunch);
            }
            else if (x.Contains(lunch))
            {
                x.Remove(lunch);
                x.Add(lunch);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btn_chooseDrinks_Click(object sender, EventArgs e)
        {
            this.Hide();
            TakingDrinksOrder waiterPage = new TakingDrinksOrder();
            waiterPage.ShowDialog();
            this.Close();
        }

        private void btn_backLunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            TakingLunchOrder waiterPage = new TakingLunchOrder();
            waiterPage.ShowDialog();
            this.Close();
        }
    }
}
