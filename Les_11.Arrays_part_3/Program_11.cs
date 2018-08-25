using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1d and 2d string arrays // and dinamic array
namespace Les_11
{
    class Program_11
    {
        static void Main(string[] args)
        {
            string[] s = new string[100];
            int n;

            Console.WriteLine("Enter size of the array: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
            }

            Console.WriteLine("Rsult: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(s[i] + ", ");
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");

            int[,] a1 = new int[5, 5];
            int[,] a2 = new int[5, 5] { {1, 2, 3, 4, 5 }, { 2, 3, 4, 5, 1}, {3, 4, 5, 1, 2 }, { 4, 5, 1, 2, 3}, {5, 1, 2, 3, 4 } };
            int[,] a3 = new int[2, 3] { { 1, 2, 3 }, { 3, 2, 1 } };

            Console.WriteLine("\n----------------------- dinamic ------------------------------------\n");

            Console.WriteLine("Enter the size of dinamic array: ");
            int m = int.Parse(Console.ReadLine());
            int[] aDin = new int[m];

            Console.WriteLine("Enter the elements of dinamic array: ");
            for(int i = 0; i < aDin.Length; i++)
            {
                Console.WriteLine("Enter el #" + i + ": ");
                aDin[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (int i = 0; i < aDin.Length; i++)
            {
                Console.WriteLine("#" + i + " " + aDin[i]);
            }

            Console.WriteLine("\n----------------------- dinamic random ------------------------------------\n");

            Random r = new Random();
            for (int i = 0; i < aDin.Length; i++)
            {
                Console.WriteLine("Enter el #" + i + ": ");
                aDin[i] = r.Next();                 // 0 - max of int
                aDin[i] = r.Next(100);              // 0 - 99
                aDin[i] = r.Next(-3, 3);            // -3 - 2
            }
            Console.WriteLine("\n");
            for (int i = 0; i < aDin.Length; i++)
            {
                Console.WriteLine("#" + i + " " + aDin[i]);
            }
        }
    }
}
