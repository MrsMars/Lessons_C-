using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_29._2
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();

            derivedClass.VMethod();                                 // VMethod from derived class
            derivedClass.Method();                                  // Usual method from derived class

            Console.WriteLine(new string('-', 50));

            // up
            BaseClass derivedClassUp = derivedClass;

            derivedClassUp.VMethod();                               // VMethod from derived class       - перезаписанный метод не изменился тк перезапись доминирует над переопределением
            derivedClassUp.Method();                                // Usual method from base class

            Console.WriteLine(new string('-', 50));

            // down

            DerivedClass derivedClassDown = (DerivedClass)derivedClassUp;

            derivedClassDown.VMethod();                             // VMethod from derived class
            derivedClassDown.Method();                              // Usual method from derived class


        }
    }
}
