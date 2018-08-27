using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Инициализаторы классов - позволяют присвоить значения всем доступным полям и свойствам объекта без вызова конструктора

namespace Les_23
{
    class Program_23
    {
        static void Main(string[] args)
        {
            Hummer hummer = new Hummer(2000)        // '(2000)' - with constructor
            {
                firm = "SomeFirm",
                Material = "tree",
                Weight = 2
                //,price = 2000               - without constructor 
            };

            Console.WriteLine(hummer.firm + ", " + hummer.Material + ", " + hummer.Weight + ", " + hummer.price);


        }
    }
}
