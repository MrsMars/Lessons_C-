using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Делегирование - передача собственности

namespace Les_40
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassB cB = new ClassB();
            cB.DoSomth();               // Action from class A
        }
    }
}
