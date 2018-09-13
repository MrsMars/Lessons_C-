using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// new 

namespace Les_47
{
    class Program
    {
        static void Main(string[] args)
        {
            // new - оператор 
            AClass aClass = new AClass();
            aClass.SayHello();

            // new - модификатор
            DerivedClass dC = new DerivedClass();
            dC.Say("ttt");                          // TTT

            // new - ограничитель
            GenericClass<AClass> gC = new GenericClass<AClass>();           // создаём экземплр класса и возвращаем ссылку на этот объект
            gC.GetNewT().SayHello();                // Hello



        }
    }
}
