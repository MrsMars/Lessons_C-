using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_30
{
    class BaseClass
    {
        public virtual void VMethod(int a, int b)
        {
            Console.WriteLine("Method amount from base class");
            Console.WriteLine(a + b);
        }
    }
}
