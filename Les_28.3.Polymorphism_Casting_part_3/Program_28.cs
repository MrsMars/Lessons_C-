using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_28._3
{
    class Program_28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------- DownCast базового класса к производному -----------------------------");

            DerivedClass derivedClass = new DerivedClass();

            derivedClass.jaket = "12313";           // Two
            derivedClass.longHair = "324324";       // propertyes

            // UpCast

            BaseClass derivedClassUp = derivedClass;
            derivedClassUp.jaket = "123";           // only this property

            // DownClas

            DerivedClass derivedClassDown = (DerivedClass)derivedClassUp;
            derivedClassDown.jaket = "22222222";
            derivedClassDown.longHair = "44444";

            Console.WriteLine("{0}, {1}, {2}", derivedClass.GetHashCode(), derivedClassUp.GetHashCode(), derivedClassDown.GetHashCode());   // 46104728, 46104728, 46104728
        }
    }
}
