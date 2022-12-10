using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{

    internal class Program
    {
        static void Main(string[] args)
        {


            /* ---- implement defalut delegate in class ------------*/
            /*
            DefaultDelegate defDeleClass = new DefaultDelegate();
            defDeleClass.showDefaultDelegate();
            */

            /* ---- implement event for default delegate in class --*/
            EventCls Ec = new EventCls();
            Ec.eventDefaultDel += new Class1().show1;
            Ec.eventDefaultDel += new Class1().show2;
            Ec.eventStartProcess();

            /* ----- test eventHandler ----------*/
            EventHandlerTest eht = new EventHandlerTest();
            eht.TestEventHandler += new EventHandlerClass1().show1;
            eht.TestEventHandler += new EventHandlerClass2().show1;
            eht.eventStartProcess();

            Console.WriteLine("Process is done!");
            Console.ReadLine();
        }


    }




}
