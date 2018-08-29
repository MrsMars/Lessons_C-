using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_29
{
    class BaseClass
    {
        public virtual void VMethod()
        {
            Console.WriteLine("VMethod from base class");
        }

        public void Method()
        {
            Console.WriteLine("Usual method from base class");
        }
    }
}
