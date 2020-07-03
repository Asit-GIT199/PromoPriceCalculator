using System;
using System.Collections.Generic;
using System.Text;
using TotalPricePromoCalculator.Enums;
using TotalPricePromoCalculator.Models;

namespace TotalPricePromoCalculator.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private List<Order> _orderList;
        List<Product> order1 = new List<Product>()
            {
            new Product() { ProductId = ProductEnum.A, ProductName = "Product A", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.B, ProductName = "Product B", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.C, ProductName = "Product C", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.D, ProductName = "Product D", ProductQuantity = 1 }
            };

        List<Product> order2 = new List<Product>()
            {
            new Product() { ProductId = ProductEnum.A, ProductName = "Product A", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.B, ProductName = "Product B", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.C, ProductName = "Product C", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.D, ProductName = "Product D", ProductQuantity = 0 }
            };

        List<Product> order3 = new List<Product>()
            {
            new Product() { ProductId = ProductEnum.A, ProductName = "Product A", ProductQuantity = 5},
            new Product() { ProductId = ProductEnum.B, ProductName = "Product B", ProductQuantity = 5 },
            new Product() { ProductId = ProductEnum.C, ProductName = "Product C", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.D, ProductName = "Product D", ProductQuantity = 0 }
            };

        List<Product> order4 = new List<Product>()
            {
            new Product() { ProductId = ProductEnum.A, ProductName = "Product A", ProductQuantity = 3},
            new Product() { ProductId = ProductEnum.B, ProductName = "Product B", ProductQuantity = 5 },
            new Product() { ProductId = ProductEnum.C, ProductName = "Product C", ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.D, ProductName = "Product D", ProductQuantity = 1 }
            };
        public OrderRepository()
        {
            _orderList = new List<Order>()
            {
                new Order() { OrderId= 1, ProductList= order1 },
                new Order() { OrderId= 2, ProductList= order2 },
                new Order() { OrderId= 3, ProductList= order3 },
                new Order() { OrderId= 4, ProductList= order4 }
            };
        }
        public IEnumerable<Order> GetAllOrders()
        {
            return _orderList;
        }
    }
}
