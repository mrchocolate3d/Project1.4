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
                string query = "";
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
                        paymentID = (int)dataRow["paymentID"],
                        employeeID = (int)dataRow["employeeID"],
                        dateorder = (DateTime)dataRow["dateorder"],
                        vat = (double)dataRow["vat"],
                        TotalPrice = (double)dataRow["totalprice"]
                    };
                    payments.Add(payment);
                }
                return payments;
            }
        }
}
