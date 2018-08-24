using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Class console
namespace Les_03
{
    class Program_03
    {
        static void Main(string[] args)
        {    
            double a, b;

            l1:                                             // Метка

            Console.Title = "Class console";

            Console.WriteLine("Enter a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            b = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;

            Console.Beep();                                 // sound
            Console.WriteLine(a * b);
            Console.WriteLine("For continue press 'Enter', for exit any key...");

            if(Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                goto l1;                // circle
            }
            else
            {
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
