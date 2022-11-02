namespace OopUppgift
{
    class Item
    {
        private Product _product;
        private decimal _quantity;

        public Item(Product product, decimal quantity)
        {
            _product = product;
            _quantity = quantity;
        }



        public decimal Price()
        {
            return _product.Price * this._quantity;
        }

        public void AddQuantity()
        {
            _quantity++;
        }

        public void AddQuantity(decimal quantity)
        {
            _quantity += quantity;
        }

        public decimal Quantity()
        {
            return this._quantity;
        }

        public Product Product()
        {
            return (Product)_product;
        }
    }
}
