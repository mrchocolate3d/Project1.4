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
    public partial class TakingDinnerOrder : Form
    {
        readonly Employee employee;
        readonly Table table;
        List<NumericUpDown> ItemCount = new List<NumericUpDown>();
        ChapeauLogic.OrderService orderServices = new ChapeauLogic.OrderService();
        List<OrderMenuItems> orderMenuItems = new List<OrderMenuItems>();
        OrderMenuItems newItem;

        public TakingDinnerOrder(Employee employee, Table table)
        {
            this.employee = employee;
            this.table = table;
            InitializeComponent();
            txt_tablenumber.Text = table.TableID.ToString();
        }

        private void AddItem_lunch_Click(object sender, EventArgs e)
        {
            grisV_Dinner.Rows.Clear();
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
                        grisV_Dinner.Rows.Add(newItem.menuItemID.ToString(), item.Name, (newItem.price * count).ToString(), item.Value);
                    }
                }
            }
        }

        private void FoodCount(object sender, EventArgs e)
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
            grisV_Dinner.Rows.Clear();
        }

        private void btn_chooseDrinks_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grisV_Dinner.Rows.Count; i++)
            {
                OrderMenuItems item = new OrderMenuItems()
                {
                    menuItemID = int.Parse(grisV_Dinner.Rows[i].Cells[0].Value.ToString()),
                    price = double.Parse(grisV_Dinner.Rows[i].Cells[2].Value.ToString()),
                    quantity = int.Parse(grisV_Dinner.Rows[i].Cells[3].Value.ToString()),
                };
                orderMenuItems.Add(item);
            }
            this.Hide();
            TakingDrinksOrder waiterPage = new TakingDrinksOrder(employee, table,orderMenuItems);
            waiterPage.ShowDialog();
            this.Close();
        }
    }
}
