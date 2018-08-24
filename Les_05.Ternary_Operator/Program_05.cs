using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ternary operator
namespace Les_05
{
    class Program_05
    {
        static void Main(string[] args)
        {
            Console.Title = "Ternary operator";

            int a;
            bool b;

            Console.WriteLine("Enter a number");
            a = int.Parse(Console.ReadLine());

            b = false;
            if(a % 3 == 0)
            {
                b = true;
            }

            Console.WriteLine(b ? (a + " is multiply to 3") : (a + " is't multiply to 3"));

            Console.ReadKey();

        }
    }
}
