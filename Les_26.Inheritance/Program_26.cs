using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Наследование

    /*      Парадигмы ООП
     *      
     *      1. Инкапсуляция
     *      2. Наследование
     *      3. Полиморфизм
     *      4. Абстракция
     *      5. Обмен сообщениями
     *      6. Повторное использование
     */

namespace Les_26
{
    class Program_26
    {
        static void Main(string[] args)
        {
            /*
            DerivedClass dClass = new DerivedClass();
            Console.WriteLine(dClass.pubField);
            */

            Console.WriteLine(new string('-', 20));

            DerivedClass dClass1 = new DerivedClass();
            Console.WriteLine(dClass1.pubField);

            Console.WriteLine("\nBefore and after reinitialization\n");


            DerivedClass dClass2 = new DerivedClass("DerivedClass.pubField");
            Console.WriteLine(dClass2.pubField);

            BaseClass bClass1 = new BaseClass();
            Console.WriteLine(dClass2.pubField);

            Console.WriteLine(new string('-', 20));

            Console.WriteLine();

            bClass1.Method();
            dClass1.Method();

        }
    }
}
