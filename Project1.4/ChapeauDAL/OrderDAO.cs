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
    public class OrderDAO : Base
    {
        public OrderMenuItem getNewOrderInfo(string name)
        {
            string query = "SELECT menuItemID, price, amount FROM menuItem WHERE itemName = '" + name + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return SelectMenuItem(ExecuteSelectQuery(query, sqlParameters));
        }

        public void NewOrder(Table table,Employee employee)
        {
            string query = $"INSERT INTO orders (tableID,employeeID,orderComplete,paidOrders) VALUES (@tableId,@employeeID,@orderComplete,@paidOrders)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@tableId", table.TableID);
            sqlParameters[1] = new SqlParameter("@employeeID", employee.EmployeeId);
            sqlParameters[2] = new SqlParameter("@orderComplete", false);
            sqlParameters[3] = new SqlParameter("@paidOrders", false);

            ExecuteEditQuery(query, sqlParameters);
        }

        public Order GetOrderID(Table table, Employee employee)
        {
            string query = "SELECT orderID FROM orders WHERE tableID = @tableId AND employeeID = @employeeID AND orderComplete = 0";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@tableId", table.TableID);
            sqlParameters[1] = new SqlParameter("@employeeID", employee.EmployeeId);
            return GetOrder(ExecuteSelectQuery(query, sqlParameters));
        }

        public void InsertMenuItem(OrderMenuItem menuItems,int id)
        {
            string query = "INSERT INTO Order_MenuItem (orderID,MenuItemID,quantity) VALUES (@orderID,@MenuItemID,@quantity)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@orderID", id);
            sqlParameters[1] = new SqlParameter("@MenuItemID", menuItems.menuItemID);
            sqlParameters[2] = new SqlParameter("@quantity", menuItems.quantity);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateTabe(Table table)
        {
            string query = "UPDATE tables SET status = @status WHERE tableID = @tableId";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@tableId", table.TableID);
            sqlParameters[1] = new SqlParameter("@status", table.status);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateStock(OrderMenuItem menuItem)
        {
            string query = "UPDATE menuItem SET amount = amount - @quantity WHERE menuItemID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@quantity", menuItem.quantity);
            sqlParameters[1] = new SqlParameter("@id", menuItem.menuItemID);
            ExecuteEditQuery(query, sqlParameters);
        }



        private Order GetOrder(DataTable dataTable)
        {
            DataRow dr = dataTable.Rows[0];
            Order id = new Order()
            {
                OrderID = (int)(dr["orderID"])
            };
            return id;
        }
        private OrderMenuItem SelectMenuItem(DataTable dataTable)
        {
            DataRow dr = dataTable.Rows[0];
            OrderMenuItem menuItem = new OrderMenuItem()
            {
                menuItemID = (int)(dr["menuItemID"]),
                price = (double)(dr["price"]),
                StockAmount = (int)(dr["amount"])
            };
            return menuItem;
        }


        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderID = (int)dr["orderID"],
                    Table = new Table((int)dr["tableID"]),
                    Employee = new Employee((int)dr["employeeID"])
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
