using System;
using System.Collections.Generic;
using System.Text;

namespace TotalPricePromoCalculator.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<Product> ProductList { get; set; }
    }
}
