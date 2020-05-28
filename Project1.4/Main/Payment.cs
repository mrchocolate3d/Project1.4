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

        private void radiobtnpaybypin_CheckedChanged(object sender, EventArgs e)
        {
            CardPayment cardPayment = new CardPayment();
            cardPayment.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ThankYouNote thankYouNote = new ThankYouNote();
            thankYouNote.Show();
        }
    }
}
