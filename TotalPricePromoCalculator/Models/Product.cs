using System;
using System.Collections.Generic;
using System.Text;
using TotalPricePromoCalculator.Enums;

namespace TotalPricePromoCalculator.Models
{
    public class Product
    {
        public ProductEnum ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
    }
}
