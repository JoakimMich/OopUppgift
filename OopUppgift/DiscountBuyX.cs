namespace OopUppgift
{
    class DiscountBuyX : IDiscount
    {
        private Product _product;
        private int _minQuantity;
        private decimal _discount;

        public DiscountBuyX(Product product, int minQuantity, decimal discount)
        {
            _product = product;
            _minQuantity = minQuantity;
            _discount = discount;
        }
        public decimal DiscountSum(Dictionary<Product, Item> items)
        {
            if (items[_product].Quantity() >= _minQuantity)
            {
                int multiplier = (int)(items[_product].Quantity() / _minQuantity);
                return _discount * multiplier;
            } else
            {
                return 0;
            }
        }
    }
}
