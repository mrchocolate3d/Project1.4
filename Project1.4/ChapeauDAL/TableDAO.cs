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
    public class TableDAO : Base
    {
        public List<Table> GetAllTables()
        {
            string query = "Select * FROM [tables]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTableTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Table> ReadTableTables(DataTable resturantTables)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in resturantTables.Rows)
            {
                Table table = new Table()
                {
                    TableID = (int)dr["tableID"],
                    status = (string)(dr["status"])
                };
                tables.Add(table);
            }
            return tables;
        }

        public List<Order> GetRunningOrders()
        {
            string query = "SELECT * FROM orders WHERE paidOrders = @paidOrder";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@paidOrder", false);
            return CreateOrders(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Order> CreateOrders(DataTable orderData)
        {
            List<Order> orders = new List<Order>();
            EmployeeDAO employeeDAO = new EmployeeDAO();
            foreach (DataRow dr in orderData.Rows)
            {
                Order order = new Order()
                {
                    Table = new Table((int)dr["tableID"]),
                    orderComplete = (bool)(dr["orderComplete"]),
                    paidOrders = (bool)(dr["paidOrders"]),
                    OrderID = (int)(dr["orderID"]),
                    EmployeeID = new Employee((int)dr["employeeID"])
                    //EmployeeID = employeeDAO.GetOne((int)dr["employeeID"])
                };
                orders.Add(order);
            }
            return orders;
        }

    }
}
