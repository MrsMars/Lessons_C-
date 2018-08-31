using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_33
{
    class DerivedClass : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Method from Derived class");
        }
    }
}
