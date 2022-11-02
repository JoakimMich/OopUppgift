using System;
using System.Collections.Generic;

namespace OopUppgift
{
    public class Checkout
    {
        private Dictionary<Product, Item> _items;
        private ProductMap _productMap;
        private DiscountMap _discountMap;

        public Checkout()
        {
            _items = new Dictionary<Product, Item>();
            _productMap = new ProductMap();
            _discountMap = new DiscountMap(_productMap);
        }

        public void AddItem(int itemId)
        {
            AddItemAux(itemId, 1, false);
        }

        public void AddItem(int itemId, decimal weight)
        {
            AddItemAux(itemId, weight, true);
        }

        private void AddItemAux(int itemId, decimal weight, bool isWeight)
        {
            Product product = _productMap.GetProduct(itemId);
            if (product.PerWeight == isWeight)
            {
                if (_items.ContainsKey(product))
                {
                    _items[product].AddQuantity(weight);
                }
                else
                {
                    _items.Add(product, new Item(product, weight));
                }
            }
        }

        public decimal Sum()
        {
            decimal sum = 0;
            decimal discount_sum = 0;

            foreach (var item in _items)
            {
                sum += item.Value.Price();
                discount_sum += _discountMap.GetDiscount(item.Key, _items);
            }

            return sum - discount_sum;
        }
    }
}