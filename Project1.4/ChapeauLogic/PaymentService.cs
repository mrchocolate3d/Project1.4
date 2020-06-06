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

        public List<Payment> GetPayments()
        {
            try
            {
                List<Payment> payments = payment_db.GetPayments();
                return payments;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
    }
}
