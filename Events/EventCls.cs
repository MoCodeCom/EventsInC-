using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class EventCls
    {
        public event DefaultDel eventDefaultDel;

        public void eventStartProcess()
        {
            Console.WriteLine("Process is start ...");
            eventDefaultDel?.Invoke();
            //implementEvent();
        }

        //--- Or implement an event in saparate method as blow ...
        public void implementEvent()
        {
            eventDefaultDel?.Invoke();
        }
    }
}
