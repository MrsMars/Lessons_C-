using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_34
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();

            IInterfaceA derivedClassUpToA = derivedClass as IInterfaceA;
            derivedClassUpToA.Method();

            IInterfaceB derivedClassUpToB = new DerivedClass();
            derivedClassUpToB.Method();
        }
    }
}
