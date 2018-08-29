using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Абстрактные классы

namespace Les_32
{
    class Program_32
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();

            derivedClass.Method();      // Method of class AClass realized in derived class
            derivedClass.Method1();     // Method1 from AClass
            derivedClass.Method2();     // Method2 from AClass
            derivedClass.Method3();     // Method3 of class AClass realized in derived class
        }
    }
}
