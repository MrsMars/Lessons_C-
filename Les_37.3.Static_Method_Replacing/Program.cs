using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Замещение статических методов

namespace Les_37._3
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass.Method();
            DerivedClass.Method();
        }
    }
}
