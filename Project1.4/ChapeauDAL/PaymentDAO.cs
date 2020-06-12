using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ChapeauDAL
{
    public class PaymentDAO: Base
    {
        public List<Payment> GetPayments(Table table)
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

        public void UpdatePaidOrders(Table table)
        {
            string query = "UPDATE orders SET paidOrders = @paidOrders WHERE tableID = @tableId AND orderComplete = @orderComplete";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@tableId", table.TableID);
            sqlParameters[1] = new SqlParameter("@paidOrders", true);
            sqlParameters[2] = new SqlParameter("@orderComplete", true);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateTable(Table table)
        {
            string query = "UPDATE [tables] SET status = 'free' WHERE tableID = @tableId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableId", table.TableID);
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Payment> ReadInfoForPayments(DataTable paymenttable)
        {
            List<Payment> payments = new List<Payment>();

            foreach (DataRow dataRow in paymenttable.Rows)
            {
                Payment payment = new Payment()
                {
                    itemName = (string)dataRow["itemName"],
                    price = (double)dataRow["price"],
                    quantity = (int)dataRow["quantity"],
                    orderID = (int)dataRow["orderID"]
                };
                payments.Add(payment);
            }
            return payments;
        }
    }
}
