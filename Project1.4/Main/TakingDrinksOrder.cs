using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ChapeauModel;


namespace ChapeauUI
{
    public partial class TakingDrinksOrder : Form
    {
        readonly Employee employee;
        readonly Table table;
        List<NumericUpDown> ItemCount = new List<NumericUpDown>();
        ChapeauLogic.OrderService orderServices = new ChapeauLogic.OrderService();
        List<OrderMenuItems> orderMenuItems;
        OrderMenuItems newItem;

        public TakingDrinksOrder(Employee employee, Table table,List<OrderMenuItems> orderMenuItems)
        {
            this.employee = employee;
            this.table = table;
            this.orderMenuItems = orderMenuItems;
            InitializeComponent();
            txt_tablenumber.Text = table.TableID.ToString();

        }

        private void AddItem_Drink_Click(object sender, EventArgs e)
        {
            gridV_Drinks.Rows.Clear();
            foreach (NumericUpDown item in ItemCount)
            {
                newItem = orderServices.getItem(item.Name);
                int count = Convert.ToInt32(item.Value);
                if (count > 0)
                {
                    if (newItem.StockAmount < count && newItem.StockAmount > 0)
                    {
                        MessageBox.Show(text: newItem.StockAmount + " left in stock.");
                    }
                    else if (newItem.StockAmount == 0)
                    {
                        MessageBox.Show(text: "Out of stock");
                    }
                    else
                    {
                        gridV_Drinks.Rows.Add(newItem.menuItemID.ToString(), item.Name, (newItem.price * count).ToString(), item.Value);
                    }
                }

            }
        }

        private void DrinksCount(object sender, EventArgs e)
        {
            CheckAmount(((NumericUpDown)sender));
        }

        private void CheckAmount(NumericUpDown lunch)
        {
            if (lunch.Value >= 1 && !(ItemCount.Contains(lunch)))
            {
                ItemCount.Add(lunch);
            }
            else if (ItemCount.Contains(lunch))
            {
                ItemCount.Remove(lunch);
                ItemCount.Add(lunch);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            gridV_Drinks.Rows.Clear();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < gridV_Drinks.Rows.Count; i++)
            {
                OrderMenuItems item = new OrderMenuItems()
                {
                    menuItemID = int.Parse(gridV_Drinks.Rows[i].Cells[0].Value.ToString()),
                    price = double.Parse(gridV_Drinks.Rows[i].Cells[2].Value.ToString()),
                    quantity = int.Parse(gridV_Drinks.Rows[i].Cells[3].Value.ToString()),
                };
                orderMenuItems.Add(item);
            }

            try
            {
                orderServices.NewOrder(table,employee);
                orderServices.UpdateTable(table);

                Order order = orderServices.getId(table, employee);
                foreach (OrderMenuItems menuItems in orderMenuItems)
                {
                    orderServices.InsertMenu(menuItems, order.OrderID);
                };

                this.Hide();
                TablePage waiterPage = new TablePage(employee);
                waiterPage.ShowDialog();
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }

          

            
        }
    }
}
