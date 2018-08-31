using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_34
{
    class DerivedClass : IInterfaceA, IInterfaceB
    {
        void IInterfaceA.Method()
        {
            Console.WriteLine("Method of interface A");
        }
        void IInterfaceB.Method()
        {
            Console.WriteLine("Method of interface B");
        }
    }
}
