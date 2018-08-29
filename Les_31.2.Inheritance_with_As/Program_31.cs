using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_31._2
{
    class Program_31
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();

            derivedClass.Method();
            derivedClass.Method1();
            derivedClass.Method2();

            // up
            BaseClass derivedClassUp = derivedClass as BaseClass;

            derivedClassUp.Method();

            // down
            DerivedClass derivedClassDown = derivedClassUp as DerivedClass; // or DerivedClass derivedClassDown = (DerivedClass)derivedClassUp;

            derivedClassDown.Method();
            derivedClassDown.Method1();
            derivedClassDown.Method2();
        }
    }
}
