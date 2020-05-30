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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn_OrderView_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuStartPage menustart = new MenuStartPage();
            menustart.ShowDialog();
            this.Close();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            //lbl_employeeName.Text = LoginPage.UserName;
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //TablePage table = new TablePage();
            //table.ShowDialog();
            //this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderView order = new OrderView();
            order.ShowDialog();
            this.Close();
        }
    }
}
