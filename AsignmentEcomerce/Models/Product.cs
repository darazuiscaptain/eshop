﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AsignmentEcomerce.Models
{
    public class Product
    {
        [Key]
        public int IDProduct { get; set; }
        [Required]
        public string NameProduct { get; set; }
        [Required]
        public string Description { get; set; }
        
        public double UnitPrice { get; set; }
        public string Image { get; set; }
        public int IDCategory { get; set; }
        [ForeignKey("IDCategory")]
        public Category Category { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }



    }
}
