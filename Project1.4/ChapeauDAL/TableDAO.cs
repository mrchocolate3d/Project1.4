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
        public List<Table> getAllTables()
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

        public List<Order> getOrderStatus()
        {
            string query = "SELECT tableID,orderComplete,paidOrders FROM orders WHERE paidOrders = @paidOrder";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@paidOrder", false);
            return ReadStatus(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Order> ReadStatus(DataTable resturantTables)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in resturantTables.Rows)
            {
                Order order = new Order()
                {
                    TableID = new Table((int)dr["tableID"]),
                    orderComplete = (bool)(dr["orderComplete"]),
                    paidOrders = (bool)(dr["paidOrders"])
                };
                orders.Add(order);
            }
            return orders;
        }

    }
}
