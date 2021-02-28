using System;

// Техника множественной диспетчеризации.

namespace Behavioral
{
    // Издатель.
    class Publisher
    {
        public void SendMessageTo(Subscriber subscriber)
        {
            subscriber.CallOperationsOn(this);
        }

        public void Operation()
        {
            Console.WriteLine("Выполнена операция.");
        }
    }

    // Подписчик.
    class Subscriber
    {
        public void CallOperationsOn(Publisher publisher)
        {
            publisher.Operation();
        }
    }
    
    class Program
    {
        static void Main()
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            // Посылка сообщения подписчику.
            publisher.SendMessageTo(subscriber);

            // Задержка.
            Console.ReadKey();
        }
    }
}
