using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_29
{
    class DerivedClass : BaseClass
    {
        public override void VMethod()
        {
            Console.WriteLine("VMethod from derived class");
        }

        new public void Method()
        {
            Console.WriteLine("Usual method from derived class");
        }
    }
}
