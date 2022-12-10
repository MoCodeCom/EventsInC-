using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void DefaultDel();
    public class DefaultDelegate
    {
        DefaultDel del_1 = new Class1().show1;
        DefaultDel del_2 = new Class2().show2;

        public void showDefaultDelegate()
        {
            del_1();
            del_2();
        }
    }

    
}
