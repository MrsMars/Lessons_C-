using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Конструкторы и base

namespace Les_27
{
    class Program_27
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass1 = new DerivedClass();

            DerivedClass derivedClass2 = new DerivedClass("SomeFirm", "SomeMaterial");
        }
    }
}
