using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Classes

    /*      how we can say
     *      1. мы создали переменную типа Имя_класса и присвоили ей адрес экземпляра в памяти 
     *      2. мы инстанцируем класс
     *      3. создали экземпляр класса ... с иименем...
     *      4. создали класс по сильной ссылке
     *      */

namespace Les_18
{


    class Program_18
    {
        static void Main(string[] args)
        {
            Hummer hummer = new Hummer();               // обращение по сильной ссылке
            hummer.material = "tree";

            Console.WriteLine(hummer.material);         // tree

            new Hummer();                               // обращение по слабой ссылке. т.е обращение каждый раз к новому элементу 
            Console.WriteLine(new Hummer().material);   //
            
        }
    }
}
