﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Entities
{
    [Table("Product")]
    public partial class Product
    {
        [Key]
        public long ID { get; set; }


        [StringLength(250)]
        public string Product_Name { get; set; }

        [StringLength(250)]
        public string Metatitle { get; set; }

        public decimal Promotion_Price { get; set; }

        public decimal Price { get; set; }

        [StringLength(250)]
        public string Image { get; set; }


        public int Quantity { get; set; }

        public long Category_ID { get; set; }

        public bool Status { get; set; }
        [InverseProperty("Products")]
        [ForeignKey("Category_ID")]
        public virtual Category Category { get; set; }
    }
}
