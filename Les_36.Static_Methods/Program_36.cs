using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Статика

namespace Les_36
{
    class Program_36
    {
        static void Main(string[] args)
        {
            MyClass mC1 = new MyClass();

            mC1.age = 17;
            mC1.height = 180;
            mC1.GetInfo();

            MyClass.field = 67;
            MyClass.StaticMethod();

            MyClass.field = 7;
            Console.WriteLine(MyClass.field);
        }
    }
}
