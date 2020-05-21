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
    public class OrdersDAO : Base
    {
        public List<Orders> GetAllOrdersInfo()
        {
            string query = "Select tableID, orderID from orders";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadLoginTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Orders> ReadLoginTables(DataTable OrdersTable)
        {
            List<Orders> orders = new List<Orders>();

            foreach (DataRow dr in OrdersTable.Rows)
            {
                Orders order = new Orders()
                {
                    tableID = (int)dr["tableID"],
                    orderID = (int)dr["orderID"]
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
