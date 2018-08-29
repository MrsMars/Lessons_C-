using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_32
{
    abstract class AClass
    {
        public abstract void Method();

        public virtual void Method1()
        {
            Console.WriteLine("Method1 from AClass");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 from AClass");
        }

        public abstract void Method3();
    }
}
