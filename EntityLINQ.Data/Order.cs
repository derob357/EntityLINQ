﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLINQ.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; }
        public double OrderTotal { get; set; }

        //Foreign Keys
        public int CustomerId { get; set; }
    }
}
