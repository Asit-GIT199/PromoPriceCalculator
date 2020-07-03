using PromoLibrary.PromoFactors;
using PromoLibrary.PromoLists;
using System;
using System.Collections.Generic;
using System.Text;
using TotalPricePromoCalculator.Enums;
using TotalPricePromoCalculator.Models;
using TotalPricePromoCalculator.ProductUnitPrice;

namespace TotalPricePromoCalculator.Services
{
    public class TotalPriceCalculatorService : ITotalPriceCalculatorService<Product>
    {
        public int TotalPriceCalculator(List<Product> productList)
        {
            var prods = productList;
            var unitPrice = new UnitPrices();
            var promotion = new PromotionList();
            var promoFactor = new PromotionFactor();
            int totalPrice = 0;
            int currentPrice = 0;
            int newCurrentPrice = 0;
            int currentPriceForC = 0;
            int currentPriceForD = 0;
            foreach (Product prod in prods)
            {

                if (prod.ProductId == ProductEnum.A)
                {
                    currentPrice = (prod.ProductQuantity / (promoFactor.Factors((int)prod.ProductId)))
                        * promotion.Promotionfor3A
                        + (prod.ProductQuantity % 3) * unitPrice.UnitPriceforA;
                }
                else if (prod.ProductId == ProductEnum.B)
                {
                    currentPrice = (prod.ProductQuantity / (promoFactor.Factors((int)prod.ProductId))) * promotion.Promotionfor2B
                        + (prod.ProductQuantity % 2) * unitPrice.UnitPriceforB;
                }
                else if (prod.ProductId == ProductEnum.C)
                {
                    currentPrice = prod.ProductQuantity * unitPrice.UnitPriceforC;
                    currentPriceForC = currentPrice;
                }
                else if (prod.ProductId == ProductEnum.D)
                {
                    currentPrice = prod.ProductQuantity * unitPrice.UnitPriceforD;
                    currentPriceForD = currentPrice;
                }

                newCurrentPrice += currentPrice;
            }
            if (currentPriceForC == unitPrice.UnitPriceforC && currentPriceForD == unitPrice.UnitPriceforD)
            {
                newCurrentPrice = (newCurrentPrice - (currentPriceForC + currentPriceForD));
                newCurrentPrice += promotion.PromotionforCnD;
            }
            totalPrice += newCurrentPrice;

            return totalPrice;
        }
    }
}
