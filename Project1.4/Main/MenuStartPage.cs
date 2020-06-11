using ChapeauModel;
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
        readonly Employee employee;
        readonly Table table;
        public MenuStartPage(Employee employee,Table table)
        {
            this.employee = employee;
            this.table = table;
            InitializeComponent();
        }

        private void btn_Lunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            TakingLunchOrder orderSelect = new TakingLunchOrder(employee, table);
            orderSelect.ShowDialog();
            this.Close();
        }

        private void btn_Dinner_Click(object sender, EventArgs e)
        {
            this.Hide();
            TakingDinnerOrder orderSelect = new TakingDinnerOrder(employee, table);
            orderSelect.ShowDialog();
            this.Close();
        }

        private void btn_Drinks_Click(object sender, EventArgs e)
        {
            this.Hide();
            TakingDrinksOrder orderSelect = new TakingDrinksOrder(employee, table);
            orderSelect.ShowDialog();
            this.Close();
        }

 
    }
}
