namespace OopUppgift
{
    class Product
    {
        private decimal _price;
        private string _name;
        private bool _perWeight;

        public Product(decimal price, string name, bool perWeight)
        {
            _price = price;
            _name = name;
            _perWeight = perWeight;
        }

        public decimal Price { get { return _price; } }
        public string Name { get { return _name; } }
        public bool PerWeight { get { return _perWeight; } }

    }
}
