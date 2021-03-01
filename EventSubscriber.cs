using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_fun
{
    class EventSubscriber
    {

        public void OnActionFinished(object sender, ActionFinishedArgs args)
        {
            Console.WriteLine($"Message Received: { args.Message }");
        }
        public void OnActionStarted(object sender, ActionStartedArgs args)
        {
            Console.WriteLine($"Message Received: { args.Message }");
        }

    }
}
