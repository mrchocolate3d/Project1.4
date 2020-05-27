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
        public List<Order> Db_Get_Order_Info()
        {
            string query = "SELECT os.orderID, m.itemName, o.quantity, os.tableID, e.employeeID" +
                "FROM menuItem AS m" + "JOIN Order_MenuItem AS o ON m.menuItemID = o.MenuItemID" +
                "JOIN orders AS os ON o.orderID = os.orderID" + "JOIN employees AS e ON os.employeeID = e.employeeID" +
                "WHERE os.orderID = 2";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderID = (int)dr["orderID"],
                    TableID = (int)dr["tableID"],
                    EmployeeID = (int)dr["employeeID"]
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
