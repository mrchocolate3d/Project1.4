﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class Reciept : Form
    {
        public Reciept()
        {
            InitializeComponent();
        }


        private void lbltablenumber_Click(object sender, EventArgs e)
        {

        }

        private void btnproceedtopayment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
        }
    }
}
