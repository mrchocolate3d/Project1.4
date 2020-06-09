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
            string query = "select itemName, price, quantity, orderID from Order_MenuItem " +
                "inner join menuItem on menuItem.menuItemID = Order_MenuItem.MenuItemID where orderID = 1";
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
