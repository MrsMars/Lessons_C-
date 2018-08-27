using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_25
{
    partial class Hummer
    {
        partial void Method1()
        {
            Console.WriteLine("Method1");
        }

        partial void Method2()
        {
            Console.WriteLine("Method2");
        }

        public void StartMethods()
        {
            Method1();
            Method2();
        }
        // Method1   - error тк они могут быть запущены только внутри своего родного класса через (в данном случае) другой метод
    }
}
