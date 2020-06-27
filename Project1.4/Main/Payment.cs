
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
        ChapeauLogic.MenuItemService paymentService = new ChapeauLogic.MenuItemService();

        public Payment(Employee employee,Table table)
        {
            this.table = table;
            this.employee = employee;
            InitializeComponent();
            ShowPanel();
        }
        double ItemTotalPrice = 0;
        public void ShowPanel()
        {
            double TotalItemPrice = 0.00;

            List<ChapeauModel.OrderMenuItems> payments = paymentService.GetAllInfoForPayments(table);

                listViewrecipt.Items.Clear();

                foreach (ChapeauModel.OrderMenuItems item in payments)
                {
                    ListViewItem list = new ListViewItem(item.OrderId.ToString());
                    list.SubItems.Add(item.itemName);
                    list.SubItems.Add(item.quantity.ToString() + "x");
                    list.SubItems.Add(item.price.ToString("€0.00"));
                    list.SubItems.Add(TotalItemPrice.ToString("€0.00"));
                    listViewrecipt.Items.Add(list);

                    // calculates the total price of all the items bought
                    ItemTotalPrice += item.price * item.quantity;
                     // Calculates the number of quantities the item is bought multiply by its price per item.
                    TotalItemPrice = item.price * item.quantity;
                }
            lbltablenumber.Text = table.TableID.ToString();
            lblserver.Text = employee.FirstName.ToString() + " " + employee.LastName.ToString();

            double VAT = 0.21;
            double vatvalue = VAT * ItemTotalPrice;
            double totalamount = ItemTotalPrice + vatvalue;
            lbltotalprice.Text = ItemTotalPrice.ToString("€0.00");
            lblvat.Text = vatvalue.ToString("€0.00");
            lbltotalamount.Text = totalamount.ToString("€0.00");

        }

        private void btnupdateamount_Click(object sender, EventArgs e)
        {
            ShowPanel();


            float tipvalue;
            //let user enter a tip amount first
            if (txttip.Text.Length > 0)
            {
                tipvalue = float.Parse(txttip.Text);
            }
            else
            {
                tipvalue = 0;
            }
        }


        private void btnpay_Click(object sender, EventArgs e)
        {
            if (radiobtnpin.Checked || radiobtncash.Checked || radiobtnmastercard.Checked || radiobtnpaybycredit.Checked)
            {
                paymentService.UpdatePaidOrders(table);
                paymentService.UpdateTable(table);

                this.Hide();
                TablePage tablepage = new TablePage(employee);
                tablepage.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(text: "Choose an option");
            }
        }

        private void btn_Resturant_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablePage orderSelect = new TablePage(employee);
            orderSelect.ShowDialog();
            this.Close();
        }
    }
}
