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
        public List<OrderMenuItems> db_Get_MenuItems()
        {
            string query = "SELECT orderID, MenuItemID, quantity, [status], comment FROM Order_MenuItem";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderMenuItems> ReadTables(DataTable dataTable)
        {
            List<OrderMenuItems> menu = new List<OrderMenuItems>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderMenuItems item = new OrderMenuItems()
                {
                    OrderId = (int)dr["orderID"],
                    menuItemID = (int)dr["MenuItemID"],
                    quantity = (int)dr["quantity"],
                    status = (int)dr["[status]"],
                    comments = (string)dr["comment"]
                };
                menu.Add(item);
            }
            return menu;
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
