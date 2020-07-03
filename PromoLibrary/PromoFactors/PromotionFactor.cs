using System;
using System.Collections.Generic;
using System.Text;

namespace PromoLibrary.PromoFactors
{
    public class PromotionFactor
    {
        public int Factors(int productId)
        {
            if (productId == 1)
            {
                return 3;
            }
            else if (productId == 2)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
    }
}
