using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_33
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();

            derivedClass.Method1();
            derivedClass.Method2();
            derivedClass.Method3();

            IInterface2 derivedClassUpToI2 = derivedClass;

            derivedClassUpToI2.Method1();
            derivedClassUpToI2.Method2();




        }
    }
}
