using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{

    public class EventHandlerTest
    {
        public event EventHandler TestEventHandler;
        public void eventStartProcess(/*EventArgs e*/)
        {
            Console.WriteLine("eventHandler start ...");
            //TestEventHandler?.Invoke(this, e);
            //******** Or by saparte event implemention method ************//
            eventImplement(EventArgs.Empty);
        }

        public void eventImplement(EventArgs e)
        {
            TestEventHandler?.Invoke(this, e);
        }
    }

}
