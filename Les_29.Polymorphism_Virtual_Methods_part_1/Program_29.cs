using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Полимрфизм (виртуальные члены)

namespace Les_29
{
    class Program_29
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();              // Method from derived class
        }
    }
}
