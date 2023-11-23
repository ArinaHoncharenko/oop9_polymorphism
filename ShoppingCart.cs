using System.Collections.Generic;

namespace oop9_products
{
    public class ShoppingCart
    {
        private List<Product> products = new List<Product>();

        public List<Product> Products
        {
            get { return products; }
        }

        public void AddToCart(Product product)
        {
            products.Add(product);
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (Product product in products)
            {
                total += product.CalculateTotal();
            }
            return total;
        }
    }
}
