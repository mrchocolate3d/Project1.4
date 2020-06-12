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
        private const string Format = "yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss";

        public List<Order> Db_Get_Order_Info()
        {
            string query = "SELECT os.orderID, m.itemName, o.quantity, os.tableID, e.employeeID" +
                "FROM menuItem AS m" + "JOIN Order_MenuItem AS o ON m.menuItemID = o.MenuItemID" +
                "JOIN orders AS os ON o.orderID = os.orderID" + "JOIN employees AS e ON os.employeeID = e.employeeID" +
                "WHERE os.orderID = 2";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public OrderMenuItems getNewOrderInfo(string name)
        {
            string query = "SELECT menuItemID, price, amount FROM menuItem WHERE itemName = '" + name + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return SelectMenuItem(ExecuteSelectQuery(query, sqlParameters));
        }

        public void NewOrder(Table table,Employee employee)
        {
            string query = $"INSERT INTO orders (tableID,employeeID,orderComplete) VALUES (@tableId,@employeeID,@orderComplete)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@tableId", table.TableID);
            sqlParameters[1] = new SqlParameter("@employeeID", employee.EmployeeId);
            sqlParameters[2] = new SqlParameter("@orderComplete", false);
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

        public void InsertMenuItem(OrderMenuItems menuItems,int id)
        {
            string query = "INSERT INTO Order_MenuItem (orderID,MenuItemID,quantity,status) VALUES (@orderID,@MenuItemID,@quantity,@status)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@orderID", id);
            sqlParameters[1] = new SqlParameter("@MenuItemID", menuItems.menuItemID);
            sqlParameters[2] = new SqlParameter("@quantity", menuItems.quantity);
            sqlParameters[3] = new SqlParameter("@status", 0);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateTabe(Table table)
        {
            string query = "UPDATE tables SET status = 'occupied' WHERE tableID = @tableId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableId", table.TableID);
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
        private OrderMenuItems SelectMenuItem(DataTable dataTable)
        {
            DataRow dr = dataTable.Rows[0];
            OrderMenuItems menuItem = new OrderMenuItems()
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
                    TableID = new Table((int)dr["tableID"]),
                    EmployeeID = new Employee((int)dr["employeeID"])
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
