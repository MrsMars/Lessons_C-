using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_30
{
    class Program_30
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();

            derivedClass.VMethod(1, 2);     // Method amount from derived class
                                            // 3
                                            // Method amount from base class
                                            // 3

        }
    }
}
