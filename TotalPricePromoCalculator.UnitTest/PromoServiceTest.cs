using System;
using System.Collections.Generic;
using System.Text;
using TotalPricePromoCalculator.Enums;
using TotalPricePromoCalculator.Models;
using TotalPricePromoCalculator.Services;
using Xunit;

namespace TotalPricePromoCalculator.UnitTest
{
    public class PromotionServiceFixture
    {
        public TotalPriceCalculatorService priceCalculator = new TotalPriceCalculatorService();
    }
    public class PromoServiceTest : IClassFixture<PromotionServiceFixture>
    {
        private readonly PromotionServiceFixture _promotionServiceFixture;
        public PromoServiceTest(PromotionServiceFixture promotionServiceFixture)
        {
            _promotionServiceFixture = promotionServiceFixture;
        }

        [Fact]
        public void One_value_of_Product_ABC_shouldbe_the_sum_of_Unit_price()
        {
            var promo = _promotionServiceFixture.priceCalculator;
            var mockOrder = new List<Product>()
            {
            new Product() { ProductId = ProductEnum.A, ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.B, ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.C, ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.D, ProductQuantity = 1 }
            };

            var result = promo.TotalPriceCalculator(mockOrder);
            Assert.Equal(110, result);
        }
        [Fact]
        public void More_than_three_of_ProdcutA_will_apply_Promotionfor3A()
        {
            var promo = _promotionServiceFixture.priceCalculator;
            var mockOrder = new List<Product>()
            {
            new Product() { ProductId = ProductEnum.A, ProductQuantity = 5 },
            new Product() { ProductId = ProductEnum.B, ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.C, ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.D, ProductQuantity = 0 }
            };

            var result = promo.TotalPriceCalculator(mockOrder);
            Assert.Equal(280, result);
        }

        [Fact]
        public void More_than_two_of_ProdcutB_will_apply_Promotionfor2B()
        {
            var promo = _promotionServiceFixture.priceCalculator;
            var mockOrder = new List<Product>()
            {
            new Product() { ProductId = ProductEnum.A, ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.B, ProductQuantity = 5 },
            new Product() { ProductId = ProductEnum.C, ProductQuantity = 0 },
            new Product() { ProductId = ProductEnum.D, ProductQuantity = 1 }
            };

            var result = promo.TotalPriceCalculator(mockOrder);
            Assert.Equal(185, result);
        }

        [Fact]
        public void For_prodduct_CandD_both_exists_then_applu_PromotionforCnD()
        {
            var promo = _promotionServiceFixture.priceCalculator;
            var mockOrder = new List<Product>()
            {
            new Product() { ProductId = ProductEnum.A, ProductQuantity = 5 },
            new Product() { ProductId = ProductEnum.B, ProductQuantity = 5 },
            new Product() { ProductId = ProductEnum.C, ProductQuantity = 1 },
            new Product() { ProductId = ProductEnum.D, ProductQuantity = 1 }
            };

            var result = promo.TotalPriceCalculator(mockOrder);
            Assert.Equal(380, result);
        }
    }
}
