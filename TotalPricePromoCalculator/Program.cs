using System;
using System.Collections.Generic;
using TotalPricePromoCalculator.Enums;
using TotalPricePromoCalculator.Models;

namespace TotalPricePromoCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var order1 = new List<Product>()
            {
            new Product() { ProductId = ProductEnum.A, ProductName = "Product A", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.B, ProductName = "Product B", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.C, ProductName = "Product C", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.D, ProductName = "Product D", ProductQuantity = 1 }
            };

            var order2 = new List<Product>()
            {
            new Product() { ProductId = ProductEnum.A, ProductName = "Product A", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.B, ProductName = "Product B", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.C, ProductName = "Product C", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.D, ProductName = "Product D", ProductQuantity = 0 }
            };

            var order3 = new List<Product>()
            {
            new Product() { ProductId = ProductEnum.A, ProductName = "Product A", ProductQuantity = 5},
            new Product() { ProductId = ProductEnum.B, ProductName = "Product B", ProductQuantity = 5 },
            new Product() { ProductId = ProductEnum.C, ProductName = "Product C", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.D, ProductName = "Product D", ProductQuantity = 0 }
            };

            var order4 = new List<Product>()
            {
            new Product() { ProductId = ProductEnum.A, ProductName = "Product A", ProductQuantity = 3},
            new Product() { ProductId = ProductEnum.B, ProductName = "Product B", ProductQuantity = 5 },
            new Product() { ProductId = ProductEnum.C, ProductName = "Product C", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.D, ProductName = "Product D", ProductQuantity = 1 }
            };

            var allOrders = new List<List<Product>>();
            allOrders.Add(order1);
            allOrders.Add(order2);
            allOrders.Add(order3);
            allOrders.Add(order4);

            Console.WriteLine("Hello World!");
        }
    }
}
