﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderMenuItems
    {
        public int OrderId { get; set; }

        public int menuItemID { get; set; }

        public float quantity { get; set; }

        public string comments { get; set; }

        public string itemName { get; set; }
        public int status { get; set; }


    }
}