using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Вложенные классы. Nested

namespace Les_41
{
    class Program
    {
        static void Main(string[] args)
        {
            MainClass.NestedClass nC = new MainClass.NestedClass();

            nC.Method();        // Method from NestedClass

            ///////////////////////////////////////////

            MainClass.DerivedNestedClass dN = new MainClass.DerivedNestedClass("Hello");

            Console.WriteLine(dN.GetField());       // Hello
            dN.BaseMethod();                        // Method from BaseClass
            dN.Shout("I LOVE C#");                  // I LOVE C# said loudly
        }
    }
}
