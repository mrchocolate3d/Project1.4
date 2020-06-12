
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
        Table table;
        Employee employee;
        public Payment(Employee employee,Table table)
        {
            this.table = table;
            this.employee = employee;
            InitializeComponent();
        }
        double ItemTotalPrice = 0;
        public void ShowPanel()
        {
               ChapeauLogic.PaymentService paymentService = new ChapeauLogic.PaymentService();
                List<ChapeauModel.Payment> payments = paymentService.GetPayments(table);

                listViewrecipt.Items.Clear();

                foreach (ChapeauModel.Payment item in payments)
                {
                    ListViewItem list = new ListViewItem(item.itemName);
                    list.SubItems.Add(item.price.ToString());
                    list.SubItems.Add(item.quantity.ToString());
                    list.SubItems.Add(item.orderID.ToString());
                    listViewrecipt.Items.Add(list);
                    ItemTotalPrice += item.price;
                }
        }

        private void btnprintrecipt_Click(object sender, EventArgs e)
        {
            ShowPanel();

            double VAT = 0.21;
            int tipvalue;
            //let user enter a tip amount first
            if (txttip.Text.Length > 0)
            {
                tipvalue = int.Parse(txttip.Text);
            }
            else
            {
                tipvalue = 0;
            }
            

            double vatvalue = VAT * ItemTotalPrice;

            double totalamount = ItemTotalPrice+ vatvalue + tipvalue;

            // displays the values on the screen
            lbltablenumber.Text = table.TableID.ToString();
            lblserver.Text = employee.FirstName.ToString() +" " + employee.LastName.ToString();
            lbltotalprice.Text = ItemTotalPrice.ToString("0.00");
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
