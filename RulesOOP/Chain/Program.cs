using System;

// Техника множественной диспетчеризации.

namespace Behavioral
{
    class Link1
    {
        public void Method()
        {
            Console.WriteLine("Link1");
        }
    }

    class Link2
    {
        Link1 link;

        public void Method()
        {
            link = new Link1();
            link.Method();
            Console.WriteLine("Link2");
        }
    }

    class Link3
    {
        Link2 link;

        public void Method()
        {
            link = new Link2();
            link.Method();
            Console.WriteLine("Link3");
        }
    }

    class Program
    {
        static void Main()
        {
            Link3 chain = new Link3();
            chain.Method();

            // Задержка.
            Console.ReadKey();
        }
    }
}
