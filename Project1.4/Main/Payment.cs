
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
        ChapeauLogic.OrderMenuItemService paymentService = new ChapeauLogic.OrderMenuItemService();

        public Payment(Employee employee,Table table)
        {
            this.table = table;
            this.employee = employee;
            InitializeComponent();
            ShowPanel();
        }
        // We make these variables as global as we need this things to save it in the database.
        float TotalPriceOfEachItem = 0;
        float vatvalue = 0.00f;
        int orderid = 0;
        float totalamount;
        private void ShowPanel()
        {
            float TotalItemPrice = 0.00f;
            

            List<ChapeauModel.OrderMenuItem> payments = paymentService.GetAllInfoForPayments(table);

                listViewrecipt.Items.Clear();

                foreach (ChapeauModel.OrderMenuItem item in payments)
                {
                       ListViewItem list = new ListViewItem(item.itemName);
                       list.SubItems.Add(item.quantity.ToString() + "x");
                       list.SubItems.Add(item.price.ToString("€0.00"));
                       listViewrecipt.Items.Add(list);
                    
                       // Calculates the number of quantities the item is bought multiply by its price per item.
                       TotalItemPrice = (float)item.price * item.quantity;

                       // calculates the total price of all the items bought
                       TotalPriceOfEachItem += TotalItemPrice;
                       list.SubItems.Add(TotalItemPrice.ToString("€0.00"));

                       orderid = item.OrderId;
                       lblorderid.Text = item.OrderId.ToString();
                }

                lbltablenumber.Text = table.TableID.ToString();
                lblserver.Text = employee.FirstName.ToString() + " " + employee.LastName.ToString();

            double VAT = 0.21;
            vatvalue = (float)VAT * TotalPriceOfEachItem;
            totalamount = TotalPriceOfEachItem;
            lbltotalprice.Text = TotalPriceOfEachItem.ToString("€0.00");
            lblvat.Text = vatvalue.ToString("€0.00");
            lbltotalamount.Text = totalamount.ToString("€0.00");

        }

        float tipvalue;
        private void btnupdateamount_Click(object sender, EventArgs e)
        {

           
            //let user enter a tip amount first
            if (txttip.Text.Length > 0)
            {
                tipvalue = float.Parse(txttip.Text);
                TotalPriceOfEachItem += tipvalue;
            }
            else
            {
                tipvalue = 0;
            }
            lbltotalamount.Text = TotalPriceOfEachItem.ToString("€0.00");
        }

        
        private void btnpay_Click(object sender, EventArgs e)
        {
            string paymentmethod = "";
            if (radiobtnpin.Checked || radiobtncash.Checked || radiobtnmastercard.Checked)
            {
                if (radiobtnpin.Checked)
                {
                    paymentmethod = "pin";
                }
                else if (radiobtncash.Checked)
                {
                    paymentmethod = "Cash";
                }
                else if (radiobtnmastercard.Checked)
                {
                    paymentmethod = "Credit card";
                }
                paymentService.UpdatePaidOrders(table);
                paymentService.UpdateTable(table);
                DateTime dateTime = DateTime.Now;
                string date = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
                paymentService.SaveOrders(orderid,employee.EmployeeId,paymentmethod,date,vatvalue,tipvalue,totalamount);

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
