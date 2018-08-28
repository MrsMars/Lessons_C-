using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_28._4
{
    class Program_28
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();                              // Method from derived class

            BaseClass derivedClassUp = derivedClass;
            derivedClassUp.Method();                            // Method from base class - открылся метод из базового класса тк привели производный класс к базовому

            DerivedClass derivedClassDown = (DerivedClass)derivedClassUp;
            derivedClassDown.Method();                          // Method from derived class - тк мы привели базовый класс к производому
        }
    }
}
