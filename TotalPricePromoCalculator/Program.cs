using System;
using System.Collections.Generic;
using TotalPricePromoCalculator.Enums;
using TotalPricePromoCalculator.Models;
using TotalPricePromoCalculator.Repository;
using TotalPricePromoCalculator.Services;

namespace TotalPricePromoCalculator
{
    class Program
    {
        static void Main(string[] args)
        {           

            IOrderRepository OrderRepository = new OrderRepository();
            var allOrders = OrderRepository.GetAllOrders();

            ITotalPriceCalculatorService<Product> totalPriceService = new TotalPriceCalculatorService();
            foreach (var order in allOrders)
            {
                foreach (var ord in order.ProductList)
                {
                    Console.WriteLine($"For Order Id {order.OrderId} for {ord.ProductName} the quantity is {ord.ProductQuantity}");

                }
                Console.WriteLine($"Total price for Order: {order.OrderId} is {totalPriceService.TotalPriceCalculator(order.ProductList)}");
                Console.WriteLine("---------------------------");
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
