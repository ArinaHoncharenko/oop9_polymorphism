using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop9_products
{
    public partial class Form1 : Form
    {
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public double Weight { get; set; }
            public string Brand { get; set; }
            public bool InStock { get; set; }

            public virtual double CalculateTotal()
            {
                return Price * Weight;
            }
        }

        public class Meat : Product
        {
            public Meat(string name, double price, double weight, string brand, bool inStock)
            {
                Name = name;
                Price = price;
                Weight = weight;
                Brand = brand;
                InStock = inStock;
            }
        }

        public class Vegetables : Product
        {
            public Vegetables(string name, double price, double weight, bool inStock)
            {
                Name = name;
                Price = price;
                Weight = weight;
                InStock = inStock;
            }
        }

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

        public Form1()
        {
            InitializeComponent();
        }

        private ShoppingCart cart = new ShoppingCart();

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            // Код для добавления товара в корзину
            string productName = textBoxProductName.Text;
            double price = 10.99; // Ваша логика получения цены
            double weight = Convert.ToDouble(numericUpDownQuantity.Value); // Извлечение веса из числового поля
            string brand = "SomeBrand"; // Ваша логика получения бренда
            bool inStock = true; // Ваша логика определения наличия

            Meat meatProduct = new Meat(productName, price, weight, brand, inStock);
            cart.AddToCart(meatProduct);

            // Очистка полей после добавления товара
            textBoxProductName.Clear();
            numericUpDownQuantity.Value = 0;

            // Обновление списка продуктов в корзине
            UpdateShoppingCartList();
        }

        private void buttonCalculateTotal_Click(object sender, EventArgs e)
        {
            // Код для расчета и вывода общей стоимости
            double total = cart.CalculateTotal();
            labelTotal.Text = $"Total: {total:C}";
        }

        // Метод для обновления списка продуктов в ListBox
        private void UpdateShoppingCartList()
        {
            listBoxShoppingCart.Items.Clear();
            foreach (Product product in cart.Products)
            {
                listBoxShoppingCart.Items.Add($"{product.Name} - {product.CalculateTotal():C}");
            }
        }
    }
}
