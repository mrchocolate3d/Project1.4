using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using ChapeauModel;

namespace ChapeauDAL
{
    public class MenuItemsDAO : Base
    {
        public void UpdateState(Order order)
        {
            string query = "UPDATE orders SET orderComplete = @orderComplete WHERE orderid = @id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@orderComplete", true);
            sqlParameters[1] = new SqlParameter("@id", order.OrderID);
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<OrderMenuItem> db_Get_MenuItems(int orderno)
        {
            string query = $"SELECT m.itemName, om.quantity, om.comment FROM Order_MenuItem AS om JOIN menuItem as m on om.MenuItemID = m.menuItemID WHERE om.orderID = {orderno}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadItem(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderMenuItem> db_Get_MenuItems_Dishes(int orderno)
        {
            string query = $"SELECT m.itemName, om.quantity, om.comment FROM Order_MenuItem AS om JOIN menuItem as m on om.MenuItemID = m.menuItemID WHERE om.orderID = {orderno} AND categoryID < 7";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadItem(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderMenuItem> db_Get_MenuItems_Drinks(int orderno)
        {
            string query = $"SELECT m.itemName, om.quantity, om.comment FROM Order_MenuItem AS om JOIN menuItem as m on om.MenuItemID = m.menuItemID WHERE om.orderID = {orderno} AND categoryID > 6";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadItem(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderMenuItem> ReadItem(DataTable dataTable)
        {
            List<OrderMenuItem> order = new List<OrderMenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderMenuItem item = new OrderMenuItem()
                {
                    itemName = (string)dr["itemName"],
                    quantity = (int)dr["quantity"],
                    comments = (string)dr["comment"],
                };
                order.Add(item);
            }
            return order;
        }

       
        // Selects all the values required for the payment section
        public List<OrderMenuItem> db_GetPayments(Table table)
        {
            string query = "select itemName, price, quantity, orders.orderID from Order_MenuItem " +
               "inner join menuItem on menuItem.menuItemID = Order_MenuItem.MenuItemID " +
               "inner join orders on Order_MenuItem.orderID = orders.orderID " +
               "inner join[tables] on[tables].tableID = orders.tableID " +
               "where orders.tableID = @tableId AND paidOrders = @paidOrders";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@tableId", table.TableID);
            sqlParameters[1] = new SqlParameter("@paidOrders", false);

            return ReadInfoForPayments(ExecuteSelectQuery(query, sqlParameters));
        }
        // Reads all the information from the database required for payments
        private List<OrderMenuItem> ReadInfoForPayments(DataTable dataTable)
        {
            List<OrderMenuItem> paymentItems = new List<OrderMenuItem>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                OrderMenuItem items = new OrderMenuItem()
                {
                    OrderId = (int)dataRow["orderID"],
                    itemName = (string)dataRow["itemName"],
                    quantity = (int)dataRow["quantity"],
                    price = (double)dataRow["price"]
                };
                paymentItems.Add(items);
            }
            return paymentItems;
        }
        // updates weather the particular order is paid or not.
        public void UpdatePaidOrders(Table table)
        {
            string query = "UPDATE orders SET paidOrders = @paidOrders WHERE tableID = @tableId AND orderComplete = @orderComplete";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@tableId", table.TableID);
            sqlParameters[1] = new SqlParameter("@paidOrders", true);
            sqlParameters[2] = new SqlParameter("@orderComplete", true);
            ExecuteEditQuery(query, sqlParameters);
        }
        // Changes the state of the table from occupied to free after the completion of the payment.
        public void UpdateTable(Table table)
        {
            string query = "UPDATE [tables] SET status = 'free' WHERE tableID = @tableId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableId", table.TableID);
            ExecuteEditQuery(query, sqlParameters);
        }
        // Saves the orders of the payment into the database
        public void SaveOrders(int paymentid, int orderid, int employeeID, string paymentmethod, DateTime dateTime,float vat, float tip, float totalprice)
        {
            string query = $"INSERT INTO payment(paymentID,orderID,employeeID,paymentMethod,vat,tip,totalprice) VALUES({paymentid}, {orderid}, {employeeID}, {paymentmethod},{dateTime} ,{vat}, {tip}, {totalprice})";
            SqlParameter[] sqlParameter = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameter);
        }

        public void db_add_item_order(int orderID, int menuItemID, int quantity, int status, string comment)
        {
            string query = $"INSERT INTO Order_MenuItem(orderID,MenuItemID,quantity,[status],comment) VALUES({orderID},{menuItemID},{quantity},{status},{comment})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void db_remove_item_order()
        {
            string query = $"UPDATE Order_MenuItem SET quantity = (0) WHERE MenuItemID (1)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
