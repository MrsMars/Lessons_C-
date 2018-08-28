using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Полиморфизм (приведение типов)

/*
 *      Приведение к базовому типу используется для сокрытия реализаций членов производного класса
 *      BaseClass baseClass = new DerivedClass() - переменная baseClass хранит ссылку на экземпляр класса DerivedClass
 *      Замещение:     UpCast & DownCast
 *                  _________________
 *                  | базовый класс |
 *                  |_______________|
 *             up ^     
 *                  _____________________
 *                  | производный класс |
 *                  |___________________|        
 *                  
 *   Замещение - создание в производном классе, метода с тем же именем, что и в базовом
 *      UpCast   - приведение экземпляра производного типа к базовому. бывает явным и неявным
 *          1.  DC dC = new DC();
 *              BC dCUp = (BC)dC;       - приводим экземпляр dC, хранящий ссылку на объект DC к базовому типу BC. явное
 *              
 *          2.  DC dC = new DC();
 *              BC dCUp = dC;           - неявное
 *              
 *          3.  BC dCUp = new DC();     - по слабой ссылке
 *      DownCast    - Приведение экземплра базового типа к производному. Только явный. Невозможен без UpCast
 *          1.  '1' or '2' из UpCast
 *          2.  DC dCDown = (DC)dCUp;       - создаём экземпляр производного класса, затем приводим его к базовому типу, затем переменую dCUp приводим к производному типу
 *      
 */      

namespace Les_28
{
    class Program_28
    {
        static void Main(string[] args)
        {
            // 1
            DerivedClass derivedClass1 = new DerivedClass();
            Console.WriteLine(derivedClass1.jaket + " " + derivedClass1.longHair);      // costum long

            BaseClass derivedClassUp1 = (BaseClass)derivedClass1;
            Console.WriteLine(derivedClassUp1.jaket);                                   // costum 

            // 2
            DerivedClass derivedClass2 = new DerivedClass();
            Console.WriteLine(derivedClass2.jaket + " " + derivedClass2.longHair);      // costum long

            BaseClass derivedClassUp2 = derivedClass2;
            Console.WriteLine(derivedClassUp2.jaket);                                   // costum 

            // 3
            BaseClass derivedClass3 = new DerivedClass();
            Console.WriteLine(derivedClassUp2.jaket);                                   // costum 




        }
    }
}
