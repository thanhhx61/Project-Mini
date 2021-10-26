using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models.Cart
{
    public class CartItem
    {
        public int Quantity { get; set; }
        public ProductItem Product { get; set; }
    }
}
