using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_30._3
{
    class Program_30
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();

            derivedClass.Method(1, 2);              // Method amount from derived class
                                                    // 3
                                                    // Method amount from base class
                                                    // 3
        }
    }
}
