using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_29
{
    class DerivedClass : BaseClass
    {
        public override void Method()
        {
            Console.WriteLine("Method from derived class");
        }
    }
}
