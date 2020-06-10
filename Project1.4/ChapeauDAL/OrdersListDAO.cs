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
    public class OrdersListDAO : Base
    {
        public List<OrdersList> GetAllOrdersInfo()
        {
            string query = "SELECT tableID, orderID FROM orders";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrdersTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrdersList> ReadOrdersTable(DataTable dataTable)
        {
            List<OrdersList> orders = new List<OrdersList>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrdersList order = new OrdersList
                {
                    tableID = new Table((int)dr["tableID"]),
                    orderID = (int)dr["orderID"]
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}