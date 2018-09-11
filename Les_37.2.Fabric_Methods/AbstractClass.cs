using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_37
{
    abstract class AbstractClass
    {
        public static AbstractClass Create()
        {
            return new MyClass();
        }

        public virtual void Method()
        {

        }
    }
}
