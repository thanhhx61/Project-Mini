using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models.Cart
{
    public class ProductItem
    {
        public long ProductId { get; set; }
        public string ProdcutName { get; set; }
        public decimal Priceproduct { get; set; }
        public decimal Promotion_Price { get; set; }
        public string Photo { get; set; }
        public string Metatitle { get; set; }
        public long CategoryId { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
    }
}
