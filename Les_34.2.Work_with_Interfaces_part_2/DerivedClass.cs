using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_34
{
    class DerivedClass : IInterfaceB
    {
        void IInterfaceA.Method()
        {
            Console.WriteLine("Method from interface A");
        }
        void IInterfaceB.Method()
        {
            Console.WriteLine("Method from interface B");
        }
    }
}
