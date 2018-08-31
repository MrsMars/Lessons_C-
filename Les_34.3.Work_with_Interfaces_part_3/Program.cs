using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_34._3
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();

            derivedClass.Method();

            IInterfaceA derivedClassUpToA = derivedClass as IInterfaceA;
            derivedClassUpToA.Method();

            IInterfaceB derivedClassUpToB = derivedClass;
            derivedClassUpToB.Method();
        }
    }
}
