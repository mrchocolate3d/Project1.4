﻿using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauLogic
{
    class PaymentService
    {
        PaymentDAO payment_db = new PaymentDAO();

        public List<Payment> GetPayments(int orderid)
        {
            try
            {
                List<Payment> payments = payment_db.GetPayments(orderid);
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