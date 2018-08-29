using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_30
{
    class DerivedClass : BaseClass
    {
        new public void Method(int a, int b)
        {
            Console.WriteLine("Method from derived class");
            Console.WriteLine(a + b);

            base.Method(a, b);
        }

    }
}
