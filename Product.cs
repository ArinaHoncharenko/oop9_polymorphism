using System;

namespace oop9_products
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
    }
}