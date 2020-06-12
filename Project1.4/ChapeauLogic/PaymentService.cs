using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauLogic
{
    public class PaymentService
    {
        PaymentDAO payment_db = new PaymentDAO();

        public List<Payment> GetPayments(Table table)
        {
            try
            {
                List<Payment> payments = payment_db.GetPayments(table);
                return payments;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public void Update(Table table)
        {
            payment_db.UpdatePaidOrders(table);
        }

        public void UpdateTable(Table table)
        {
            payment_db.UpdateTable(table);
        }
    }
}
