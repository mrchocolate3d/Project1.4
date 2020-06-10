
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        public void ShowPanel()
        {
               ChapeauLogic.PaymentService paymentService = new ChapeauLogic.PaymentService();
                List<ChapeauModel.Payment> payments = paymentService.GetPayments();

                listViewrecipt.Items.Clear();

                foreach (ChapeauModel.Payment item in payments)
                {
                    ListViewItem list = new ListViewItem(item.itemName);
                    list.SubItems.Add(item.price.ToString());
                    list.SubItems.Add(item.quantity.ToString());
                    list.SubItems.Add(item.orderID.ToString());
                    listViewrecipt.Items.Add(list);
                }
        }

        private void btnprintrecipt_Click(object sender, EventArgs e)
        {
            ShowPanel();

            double VAT = 0.21;
            int tablenumber = 6;
            string servername = "Rachel Green";
            double totalprice = 16.5;

            // let user enter a tip amount first
            int tipvalue = int.Parse(txttip.Text);

            double vatvalue = VAT * totalprice;

            double totalamount = totalprice + vatvalue + tipvalue;

            // displays the values on the screen
            lbltablenumber.Text = tablenumber.ToString();
            lblserver.Text = servername.ToString();
            lbltotalprice.Text = totalprice.ToString("0.00");
            lblvat.Text = vatvalue.ToString("0.00");

            lbltotalamount.Text = totalamount.ToString("0.00");
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
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

        }
    }
}
