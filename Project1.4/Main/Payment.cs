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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void btncash_Click(object sender, EventArgs e)
        {
            ThankYouNote thankYouNote = new ThankYouNote();
            thankYouNote.Show();

            Reciept reciept = new Reciept();
            reciept.Hide();
        }

        private void btncreditcard_Click(object sender, EventArgs e)
        {
            CardPayment cardpayment = new CardPayment();
            cardpayment.Show();
        }
    }
}
