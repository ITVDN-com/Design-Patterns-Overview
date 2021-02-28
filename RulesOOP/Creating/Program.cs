using System;

// Техника порождения продуктов.

namespace Creating
{
    // Продукт.
    class Product
    {
        public Product()
        {
            Console.WriteLine("I'm new Product!");
        }
    }

    // Фабрика.
    class Factory
    {
        // Фабричный метод, порождающий продукты.
        public Product FactoryMethod()
        {
            return new Product();
        }
    }

    class Program
    {
        static void Main()
        {
            Factory factory = new Factory();

            Product product = factory.FactoryMethod();

            // Задержка.
            Console.ReadKey();
        }
    }
}
