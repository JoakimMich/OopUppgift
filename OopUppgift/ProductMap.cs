using System;
using System.Collections.Generic;

namespace OopUppgift
{
    class ProductMap
    {
        private static readonly Dictionary<int, Product> _products
            = new Dictionary<int, Product>
        {
            {1, new Product(24.95m, "Toothpaste", false) },
            {2, new Product(59, "Cheese", true)},
            {3, new Product(11.95m, "Bread", false)},
            {4, new Product(22.49m, "Coffee", false)},
            {5, new Product(32.95m, "Apples", true)},
            {6, new Product(11.95m, "Flour", false)},
            {7, new Product(93, "Ground Beef", true)},
            {8, new Product(9.32m, "Milk", false)}
        };

        public Product GetProduct(int id)
        {
            Product product;
            if (!_products.TryGetValue(id, out product))
            {
                throw new ArgumentException(String.Format("{0} id does not exist", id),"id");
            }
            return product;
        }
    }
}
