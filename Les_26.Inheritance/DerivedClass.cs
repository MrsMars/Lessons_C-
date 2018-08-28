using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_26
{
    class DerivedClass : BaseClass
    {
        // доступ к наследуемым элементам можно получить с помощью методов, конструкторов и тд
        public DerivedClass()
        {
            /*
            protField = "DerivedClass.ptotField";
            pubField = "DerivedClass.pubField";
            */
        }

            // 'ctor' + 'Tab"
        public DerivedClass(string s)
        {
            pubField = s;              
        }
        new public void Method()            // add 'new'
        {
            Console.WriteLine("DerivedMethod()");
        }
    }
}
