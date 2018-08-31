using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_34
{
    class DerivedClass : IInterfaceA, IInterfaceB
    {
        public void Method()
        {
            Console.WriteLine("Method from interface A and B");
        }
    }
}
