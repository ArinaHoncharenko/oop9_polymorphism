using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace oop9_products
{
    public partial class Form1 : Form
    {
        public abstract class Product
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

        public class Fruit : Product
        {
            public double Weight { get; set; }

            public Fruit(string name, double price, int quantity, double weight)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                Weight = weight;
            }

            public override double CalculateTotal()
            {
                return Price * Weight/1000;
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
            storeProducts.Add(new Fruit("Яблуки", 18, 1, 1000)); 
            storeProducts.Add(new Fruit("Банани", 56, 1, 1000));
            storeProducts.Add(new Fruit("Сливи", 87, 1, 1000));

            // Обновлено список продуктів в магазині
            UpdateStoreProductList();

            // Додано обробник події SelectedIndexChanged для comboBoxProductName
            comboBoxProductName.SelectedIndexChanged += ComboBoxProductName_SelectedIndexChanged;

            // Додано всі продукти в comboBoxProductName
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

        private void ComboBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Виводимо характеристики обраного продукту 
            string selectedProductName = comboBoxProductName.SelectedItem.ToString();
            Product selectedProduct = storeProducts.Find(product => product.Name == selectedProductName);

            if (selectedProduct is Fruit)
            {
                Fruit selectedFruit = selectedProduct as Fruit;
                labelCharacteristics.Text = $"Вартість (за кілограм): {selectedFruit.Price} UAH";
            }
            else if (selectedProduct is Clothing)
            {
                Clothing selectedClothing = selectedProduct as Clothing;
                labelCharacteristics.Text = $"Розмір: {selectedClothing.Size}\nВартість: {selectedClothing.Price} UAH";
            }
            else if (selectedProduct is Book)
            {
                Book selectedBook = selectedProduct as Book;
                labelCharacteristics.Text = $"Автор: {selectedBook.Author}";
            }
            else if (selectedProduct is Bag)
            {
                Bag selectedBag = selectedProduct as Bag;
                labelCharacteristics.Text = $"Бренд: {selectedBag.Brend}";
            }
            else
            {
                labelCharacteristics.Text = string.Empty;
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

            if (selectedProduct is Fruit)
            {
                // Якщо обраний продукт є фруктом, додайте вагу з textBoxWeight
                double weight;
                if (double.TryParse(textBoxWeight.Text, out weight))
                {
                    // Перевірка діапазону ваги
                    if (weight < 100)
                    {
                        MessageBox.Show("Мінімальна вага для замовлення - 100 г.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (weight > 8000)
                    {
                        MessageBox.Show("Максимальна вага для замовлення - 8000 г.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Додавання фрукта в корзину
                    cart.AddToCart(new Fruit(selectedProduct.Name, price, quantity, weight));
                }
                else
                {
                    MessageBox.Show("Некоректне значення ваги. Введіть числове значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                // Додавання інших продуктів в корзину
                cart.AddToCart(selectedProduct);
            }

            // Очищення полів після добавлення товару
            numericUpDownQuantity.Value = 1;

            // Оновлення списку продуктів в корзині
            UpdateShoppingCartList();
        }
        
        private void UpdateShoppingCartList()
        {
            listBoxShoppingCart.Items.Clear();
            foreach (Product product in cart.Products)
            {
                listBoxShoppingCart.Items.Add($"{product.Name} - {product.CalculateTotal()} UAH");
            }
        }

        private void buttonCalculateTotal_Click(object sender, EventArgs e)
        {
            // Код для расчета и вывода общей стоимости
            double total = cart.CalculateTotal();
            labelTotal.Text = $"Сума: {total} UAH";
        }

    }
}
