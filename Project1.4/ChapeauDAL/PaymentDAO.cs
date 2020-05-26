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
    class PaymentDAO: Base
    {
        public List<Payment> GetPayments()
        {
            string query = "";
            SqlParameter[] sqlParameter = new SqlParameter[0];
        }
    }
}
