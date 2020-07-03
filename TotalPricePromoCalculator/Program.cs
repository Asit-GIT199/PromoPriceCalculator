using System;
using System.Collections.Generic;
using TotalPricePromoCalculator.Enums;
using TotalPricePromoCalculator.Models;
using TotalPricePromoCalculator.Repository;

namespace TotalPricePromoCalculator
{
    class Program
    {
        static void Main(string[] args)
        {           

            IOrderRepository OrderRepository = new OrderRepository();
            var allOrders = OrderRepository.GetAllOrders();

            foreach (var ord in allOrders)
            {
                Console.WriteLine($"Order id {ord.OrderId}");                
            }

            Console.WriteLine("Hello World!");
        }
    }
}
