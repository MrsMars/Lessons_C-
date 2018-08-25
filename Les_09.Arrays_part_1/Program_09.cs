using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1d or static arrays
namespace Les_09
{
    class Program_09
    {
        static void Main(string[] args)
        {
            Console.Title = "Array";
            int[] a = new int[5];

            a[0] = 3;
            a[1] = 6;
            a[2] = 14;
            a[3] = 17;
            a[4] = 21;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Element #" + i + " " + a[i]);
            }

            Console.WriteLine("----------------------------------------------");

            Console.Title = "Array";
            int[] b = new int[1000];
            int s = 0;

            Console.WriteLine("Enter members of the array");
            int j = 0;

            do
            {
                Console.Write("Enter el #" + j + ": ");
                b[j] = int.Parse(Console.ReadLine());
                s += b[j];
                j++;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            

            for(int k = 0; k < j; k++)
            {
                Console.WriteLine("El #" + k + " " + b[k]);
            }
            Console.WriteLine("\nAmount of elements: " + s);

            Console.ReadKey();
        }
    }
}
