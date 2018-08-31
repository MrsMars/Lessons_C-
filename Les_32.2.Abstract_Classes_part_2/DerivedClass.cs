using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_32
{
    class DerivedClass : CClass
    {
        public override void Method()
        {
            Console.WriteLine("Method");
        }

        public override int Addition(int a, int b)
        {
            return a + b;
        }

        public override string SayHello(string s)
        {
            return $"Hello {s}!";
        }

        public void SayHello(string s, string s1)
        {
            Console.WriteLine($"Hello {s} and {s1}!");
        }

    }
}
