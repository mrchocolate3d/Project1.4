using ChapeauLogic;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int tablenumber = 6;
            string servername = "rachel green";
            double totalprice = 56.89;
            if (radiobtnpin.Checked)
            {
                CardPayment cardPayment = new CardPayment();
                cardPayment.Show();
            }
            else if (radiobtncash.Checked)
            {
                ThankYouNote thankYouNote = new ThankYouNote();
                thankYouNote.Show();
            }

            lbltablenumber.Text = tablenumber.ToString();
            lblserver.Text = servername.ToString();
            lbltotalprice.Text = totalprice.ToString("0.00");
        }
        /*
        public void ShowPanel(string panelname)
        {
            if (panelname=="pnlpayment")
            {
                PaymentService paymentService = new PaymentService();
                List<Payment> payments = paymentService.GetPayments();
            }
        }
        */
    }
}
