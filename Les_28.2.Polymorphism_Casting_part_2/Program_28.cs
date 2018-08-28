using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_28._2
{
    class Program_28
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            Console.WriteLine(derivedClass.GetHashCode());          // 46104728

            Console.WriteLine("------------------------- UpCast производного класса к базовому -----------------------------");

            Console.WriteLine("------------------------- по сильной ссылке -----------------------------");

            BaseClass derivedClassUp1 = derivedClass;         // or BaseClass baseClass = (BaseClass)derivedClass; 
            Console.WriteLine(derivedClassUp1.GetHashCode());       // 46104728

            Console.WriteLine("------------------------- по слабой ссылке -----------------------------");

            BaseClass derivedClassUp2 = new DerivedClass();
            Console.WriteLine(derivedClassUp2.GetHashCode());       // 12289376
        }
    }
}
