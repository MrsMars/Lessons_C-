using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_34
{
    class DerivedClass : AClass
    {
        public override int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
