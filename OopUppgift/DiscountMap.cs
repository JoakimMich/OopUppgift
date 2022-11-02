using System;
using System.Collections.Generic;

namespace OopUppgift
{
    class DiscountMap
    {
        private Dictionary<Product, IDiscount> _discounts;

        public DiscountMap(ProductMap products) { 
            _discounts = new Dictionary<Product, IDiscount>();
            _discounts.Add(products.GetProduct(4), new DiscountBuyX(products.GetProduct(4), 2, 4.98m));
            _discounts.Add(products.GetProduct(1), new DiscountBuyXPayY(products.GetProduct(1), 3));
            _discounts.Add(products.GetProduct(5), new DiscountTotalPrice(products.GetProduct(5), 150, 16.95m));
        }

        public decimal GetDiscount(Product product, Dictionary<Product, Item> items)
        {
            IDiscount discount;
            if (!_discounts.TryGetValue(product, out discount))
            {
                return 0;
            }
            return discount.DiscountSum(items);
        }
    }
}
