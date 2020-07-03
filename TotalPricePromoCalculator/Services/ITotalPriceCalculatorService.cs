using System;
using System.Collections.Generic;
using System.Text;

namespace TotalPricePromoCalculator.Services
{
    public interface ITotalPriceCalculatorService<T> where T : class
    {
        int TotalPriceCalculator(List<T> TList);
    }
}
