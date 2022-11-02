namespace OopUppgift
{
    class DiscountTotalPrice : IDiscount
    {
        private Product _product;
        private decimal _minTotal;
        private decimal _newPrice;

        public DiscountTotalPrice(Product product, decimal minTotal, decimal newPrice)
        {
            _product = product;
            _minTotal = minTotal;
            _newPrice = newPrice;
        }

        public decimal DiscountSum(Dictionary<Product, Item> items)
        {
            decimal sum = 0;
            foreach (var item in items)
            {
                if (item.Key != _product)
                {
                    sum += item.Value.Price();
                }
            }
            if (sum > _minTotal)
            {
                return items[_product].Price() - _newPrice * items[_product].Quantity();
            } else
            {
                return 0;
            }

        }
    }
}
