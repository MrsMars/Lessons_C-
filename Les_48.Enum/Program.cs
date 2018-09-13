using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// enum

namespace Les_48
{
    enum Number
    {
        Zero,
        One,
        Two,
        Three
    }

    class Program
    {

        private static Number myDigit = Number.One;

        static void Main(string[] args)
        {
            Number digit = Number.Two;

            Console.WriteLine(digit);       // Two
            Console.WriteLine((int)digit);  // 2

            Console.WriteLine(Number.Three);       // Three
            Console.WriteLine((int)Number.Three);  // 3

            Console.WriteLine(myDigit);         // One
            Console.WriteLine((int)myDigit);    // 1

            Console.WriteLine("\n---------------------------------------------------------\n");

            for(Number n = Number.Zero; n <= Number.Three; n++)
            {
                Console.Write($"{n} : {(int)n}\n");
            }
        }
    }
}
