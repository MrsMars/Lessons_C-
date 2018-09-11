using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_37
{
    class MyClass
    {
        public static int field = 3;

        static MyClass()
        {
            Console.WriteLine("Static constructor");
        }
        public MyClass()
        {
            Console.WriteLine("Usual constructor");
        }
    }
}
