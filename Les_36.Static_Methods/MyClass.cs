using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_36
{
    class MyClass
    {
        public int age;
        public int height;
        public static int field;

        public static void StaticMethod()
        {
            Console.WriteLine(field);
        }
        public void GetInfo()
        {
            Console.WriteLine($"Age - {age}\nHeight - {height}");
        }
    }
}
