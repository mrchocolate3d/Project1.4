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
        List<NumericUpDown> x = new List<NumericUpDown>();
        public TakingLunchOrder()
        {
            InitializeComponent();
        }

        private void AddItem_lunch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (NumericUpDown item in x)
            {
                dataGridView1.Rows.Add(item.Name,item.Value);
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
    }
}
