using System;

// Техника организации структур элементов.

namespace Structural
{
    // Элемент - часть большой структуры.
    class ElementA
    {
        public void Hello() { Console.Write("Hello "); }
    }

    // Элемент - часть большой структуры.
    class ElementB
    {
        public void World() { Console.Write("World!"); }
    }

    // Большая структура использующая в своем составе более мелкие.
    class Facade
    {
        ElementA elementA;
        ElementB elementB;

        public void HelloWorld()
        {
            elementA = new ElementA();
            elementB = new ElementB();

            elementA.Hello();
            elementB.World();
        }
    }

    class Program
    {
        static void Main()
        {
            Facade facade = new Facade();
            facade.HelloWorld();

            // Задержка.
            Console.ReadKey();
        }
    }
}
