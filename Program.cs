using System;
using System.Threading.Tasks;
using System.Xml;

namespace csharp_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();

            publisher.ActionStarted += subscriber.OnActionStarted;
            publisher.ActionFinished += subscriber.OnActionFinished;

            publisher.PerformAction();

            Console.ReadLine();
        }

    }
}
