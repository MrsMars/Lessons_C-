using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_30
{
    class DerivedClass : BaseClass
    {
        public override void VMethod(int a, int b)
        {
            Console.WriteLine("Method amount from derived class");
            Console.WriteLine(a + b);
            base.VMethod(a, b);
        }

    }
}
