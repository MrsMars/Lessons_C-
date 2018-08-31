using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_32
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();

            derivedClass.Method();                                  // Method
            Console.WriteLine(derivedClass.Addition(5, 7));         // 12
            Console.WriteLine(derivedClass.SayHello("Alco"));       // Hello Alco!

            AClass derivedClassUpToAClass = derivedClass;             // неявное приведение
            derivedClassUpToAClass.Method();

            BClass derivedClassUpToBClass = derivedClass as BClass;
            derivedClassUpToBClass.Method();
            Console.WriteLine(derivedClassUpToBClass.Addition(5, 7));

            CClass derivedClassUpToCClass = (CClass)derivedClass;
            derivedClassUpToCClass.Method();                                  
            Console.WriteLine(derivedClassUpToCClass.Addition(5, 7));         
            Console.WriteLine(derivedClassUpToCClass.SayHello("Alco"));

            derivedClass.SayHello("Jack", "John");
        }
    }
}
