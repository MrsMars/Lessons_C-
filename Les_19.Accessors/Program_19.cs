using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Методы доступа - позволяют получать доступ к закрытым полм класса
//  1. Мутаторы(сеттеры)
//  2. Аксессоры(геттеры)
// аналогом этого являются свойства set and get

namespace Les_19
{
    class Program_19
    {
        static void Main(string[] args)
        {
            Hummer hummer = new Hummer();
            
            string mat = Console.ReadLine();

            if (hummer.SetField(mat))
            {
                Console.WriteLine(hummer.GetField());
            }
            else
            {
                Console.WriteLine(mat + "- Invalid value");
            }
        }
    }
}
