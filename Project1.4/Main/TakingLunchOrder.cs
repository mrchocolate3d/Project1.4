using ChapeauModel;
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
    public partial class TakingLunchOrder : Form
    {
        readonly Employee employee;
        readonly Table table;
        List<NumericUpDown> ItemCount = new List<NumericUpDown>();
        ChapeauLogic.OrderService orderServices = new ChapeauLogic.OrderService();
        List<OrderMenuItems> orderMenuItems = new List<OrderMenuItems>();
        OrderMenuItems newItem;
        public TakingLunchOrder(Employee employee,Table table)
        {
            this.employee = employee;
            this.table = table;

            InitializeComponent();
            txt_tablenumber.Text = table.TableID.ToString();
        }

        private void AddItem_lunch_Click(object sender, EventArgs e)
        {
            gridV_Lunch.Rows.Clear();
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
                        gridV_Lunch.Rows.Add(newItem.menuItemID.ToString(), item.Name, (newItem.price * count).ToString(), item.Value);
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
            gridV_Lunch.Rows.Clear();
        }


        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            orderMenuItems.Clear();
            for (int i = 0; i < gridV_Lunch.Rows.Count; i++)
            {
                OrderMenuItems item = new OrderMenuItems()
                {
                    menuItemID = int.Parse(gridV_Lunch.Rows[i].Cells[0].Value.ToString()),
                    price = double.Parse(gridV_Lunch.Rows[i].Cells[2].Value.ToString()),
                    quantity = int.Parse(gridV_Lunch.Rows[i].Cells[3].Value.ToString()),
                };
                orderMenuItems.Add(item);
            }
            //foreach (OrderMenuItems value in orderMenuItems)
            //{
            //    commentBox.Text = value.menuItemID.ToString() + " " + value.itemName;
            // }
            //txt_tablenumber.Text = orderMenuItems.Count.ToString();

            this.Hide();
            TakingDrinksOrder waiterPage = new TakingDrinksOrder(employee, table, orderMenuItems);
            waiterPage.ShowDialog();
            this.Close();
        }

        private void gridV_Lunch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
