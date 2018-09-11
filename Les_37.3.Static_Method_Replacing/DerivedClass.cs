using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_37
{
    class DerivedClass : BaseClass
    {
        new public static void Method()
        {
            Console.WriteLine("Method from derived class");
        }
    }
}
