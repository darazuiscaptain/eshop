﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AsignmentEcomerce.Models
{
    public class OrderDetails
    {
        [Key]
        public int IDOrderDetail { get; set; }

        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public int IDOrder { get; set; }
        [ForeignKey("IDOrder")]
        public Order Order { get; set; }
        public int IDProduct { get; set; }
        [ForeignKey("IDProduct")]
        public Product Product { get; set; }
    }
}
