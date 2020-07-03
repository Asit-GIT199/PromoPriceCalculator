using System;
using System.Collections.Generic;
using System.Text;
using TotalPricePromoCalculator.Models;

namespace TotalPricePromoCalculator.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders();
    }
}
