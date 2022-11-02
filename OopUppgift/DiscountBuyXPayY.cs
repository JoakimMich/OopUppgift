namespace OopUppgift
{
    class DiscountBuyXPayY : IDiscount
    {
        private Product _product;
        private int _minQuantity;

        public DiscountBuyXPayY(Product product, int minQuantity)
        {
            _product = product;
            _minQuantity = minQuantity;
        }

        public decimal DiscountSum(Dictionary<Product, Item> items)
        {
            if (items[_product].Quantity() >= _minQuantity)
            {
                return items[_product].Product().Price;
            } else
            {
                return 0;
            }
        }
    }
}
