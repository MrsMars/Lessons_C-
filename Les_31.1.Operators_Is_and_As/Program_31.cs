using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Операторы is and as - используются для проведения преобразований между ссылочными типами

    /* 
     *      is - проверяет совместимость объекта с заданным типом. Если выражение отлично от null и объект может быть приведён к типу не вызывая исключение - true / exception
     *      as - используется для выполнения преобразования между ссылочными типами. true / null
     *      
     */


namespace Les_31
{
    class Program_31
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = null;
            DerivedClass derivedClass = new DerivedClass();

            if(derivedClass is BaseClass)                       // если мы можем представить derivedClass как BaseClass
            {
                baseClass = derivedClass;
                Console.WriteLine("UpCast complied");
            }
            else
            {
                baseClass = null;
            }

            BaseClass baseClassUp = derivedClass as BaseClass;
        }
    }
}
