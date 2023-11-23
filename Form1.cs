using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static oop9_products.Form1;

namespace oop9_products
{
    public partial class Form1 : Form
    {
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }

            public virtual double CalculateTotal()
            {
                return Price * Quantity;
            }
        }

        public class Clothing : Product
        {
            public string Size { get; set; }
            public Clothing(string name, double price, int quantity, string size)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                Size = size;
            }
        }

        public class Book : Product
        {
            public string Author { get; set; }
            public Book(string name, double price, int quantity, string author)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                Author = author;
            }
        }

        public class Bag : Product
        {
            public string Brend { get; set; }
            public Bag(string name, double price, int quantity, string brend)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                Brend = brend;
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

        private List<Product> storeProducts = new List<Product>();

        public Form1()
        {
            InitializeComponent();

            storeProducts.Add(new Clothing("Футболка", 350, 1, "M"));
            storeProducts.Add(new Clothing("Шорти", 400.7, 1, "S"));
            storeProducts.Add(new Clothing("Светер", 670, 1, "XL"));
            storeProducts.Add(new Book("Кобзар", 380.5, 1, "Т. Г. Шевченко"));
            storeProducts.Add(new Book("Тіні забутих предків", 180, 1, "М. Коцюбинський"));
            storeProducts.Add(new Book("Тигролови", 200, 1, "І. Багряний"));
            storeProducts.Add(new Bag("Рюкзак", 512, 1, "Baggg"));

            // Обновите список продуктов в магазине
            UpdateStoreProductList();

            foreach (Product product in storeProducts)
            {
                comboBoxProductName.Items.Add(product.Name);
            }

            // Встановлюємо обраний продукт за замовчуванням (перший продукт у списку)
            comboBoxProductName.SelectedIndex = 0;
        }
        private void UpdateStoreProductList()
        {
            listBoxStoreProducts.Items.Clear();
            foreach (Product product in storeProducts)
            {
                listBoxStoreProducts.Items.Add($"{product.Name} - {product.CalculateTotal()} UAH");
            }
        }


        private ShoppingCart cart = new ShoppingCart();

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            // Отримуємо обране значення з comboBoxProductName
            string selectedProductName = comboBoxProductName.SelectedItem.ToString();

            // Знаходимо продукт в магазині за його іменем
            Product selectedProduct = storeProducts.Find(product => product.Name == selectedProductName);

            // Код для добавлення обраного продукту в корзину
            double price = selectedProduct.Price;
            int quantity = Convert.ToInt32(numericUpDownQuantity.Value);

            // Вибір категорії продукту
            if (selectedProduct is Book)
            {
                Book selectedBook = selectedProduct as Book;
                cart.AddToCart(new Book(selectedBook.Name, price, quantity, selectedBook.Author));
            }
            else if (selectedProduct is Clothing)
            {
                Clothing selectedClothing = selectedProduct as Clothing;
                cart.AddToCart(new Clothing(selectedClothing.Name, price, quantity, selectedClothing.Size));
            }
            else if (selectedProduct is Bag)
            {
                Bag selectedBag = selectedProduct as Bag;
                cart.AddToCart(new Bag(selectedBag.Name, price, quantity, selectedBag.Brend));
            }

            // Очищення полів після добавлення товару
            numericUpDownQuantity.Value = 1;

            // Оновлення списку продуктів в корзині
            UpdateShoppingCartList();
        }

        private void buttonCalculateTotal_Click(object sender, EventArgs e)
        {
            // Код для расчета и вывода общей стоимости
            double total = cart.CalculateTotal();
            labelTotal.Text = $"Сума: {total} UAH";
        }

        // Метод для обновления списка продуктов в ListBox
        private void UpdateShoppingCartList()
        {
            listBoxShoppingCart.Items.Clear();
            foreach (Product product in cart.Products)
            {
                listBoxShoppingCart.Items.Add($"{product.Name} - {product.CalculateTotal()} UAH");
            }
        }

    }
}
