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
    public partial class CardPayment : Form
    {
        public CardPayment()
        {
            InitializeComponent();
        }

        private void btnconfirmpayement_Click(object sender, EventArgs e)
        {
            int cardnumber = int.Parse(txtcardnumber.Text);
            int pasnumber = int.Parse(txtpasnumber.Text);
            DateTime DateOfExpire = DateTime.Parse(txtdateofexpire.Text);
            

            // then the thankyou note is displayed 
            ThankYouNote thankYouNote = new ThankYouNote();
            thankYouNote.Show();
        }
    }
}
