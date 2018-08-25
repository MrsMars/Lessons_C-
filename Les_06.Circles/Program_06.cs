using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Circles
namespace Les_06
{
    class Program_06
    {
        static void Main(string[] args)
        {
            Console.Title = "Factorial";
            int f, n;

            Console.WriteLine("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("\t- - - for - - -");
            f = 1;
            for(int i = 1; i <= n; i++)
            {
                f *= i;
            }

            Console.WriteLine("Factorial is equal to: " + f);

            Console.WriteLine("\n\t- - - while - - -");
            f = 1;
            int j = 1;
            while(j <= n)
            {
                f *= j;
                j++;
            }
            Console.WriteLine("Factorial is equal to: " + f);

            Console.WriteLine("\n\t- - -do while - - -");
            f = 1;
            j = 1;
            do
            {
                f *= j;
                j++;
            }
            while (j <= n);
            Console.WriteLine("Factorial is equal to: " + f);
   
            Console.WriteLine();

            // is number a simple or not
            for (int i = 1; i <= f; i++)
            {
                if(f % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
