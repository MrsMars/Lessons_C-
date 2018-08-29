using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_32
{
    class DerivedClass : AClass
    {
        public override void Method()
        {
            Console.WriteLine("Method of class AClass realized in derived class");        
        }

        public override void Method3()
        {
            Console.WriteLine("Method3 of class AClass realized in derived class");
        }

    }
}
