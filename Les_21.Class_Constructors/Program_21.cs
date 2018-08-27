using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Конструкторы класса

namespace Les_21
{
    class Program_21
    {
        static void Main(string[] args)
        {
            Hummer hummer = new Hummer(2000);
            Console.WriteLine("Firm {0}, material {1}, price {2}, weiht {3}", hummer.Firm, hummer.material, hummer.price, hummer.weight);
            
        }
    }
}
