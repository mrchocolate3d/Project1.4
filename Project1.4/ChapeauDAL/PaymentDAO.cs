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
        public List<Payment> GetPayments()
        {
            string query = "SELECT m.itemName,m.price, om.quantity, o.orderID" + "FROM Order_MenuItem as om" +
                "join menuItem as m on m.menuItemID = om.MenuItemID" + "join orders as o on o.orderID = om.orderID " + 
                "WHERE o.orderID = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadInfoForPayments(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Payment> ReadInfoForPayments(DataTable paymenttable)
        {
            List<Payment> payments = new List<Payment>();

            foreach (DataRow dataRow in paymenttable.Rows)
            {
                Payment payment = new Payment()
                {
                    itemName = (string)dataRow["itemName"],
                    price = (int)dataRow["price"],
                    quantity = (int)dataRow["quantity"],
                    orderID = (int)dataRow["orderID"]
                };
                payments.Add(payment);
            }
            return payments;
        }
    }
}
