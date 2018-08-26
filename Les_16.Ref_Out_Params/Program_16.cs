using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// option transfer with 'out' and 'ref' and parameter array 'params'
// out - по значению
// ref - по сылке
namespace Les_16
{
    class Program_16
    {
        static void Add(double db_a, double db_b, out double db_s, out double db_r)
        {
            db_s = db_a + db_b;
            db_r = db_a - db_b;
        }
        static void Replace(ref int a1, ref int a2)
        {
            int temp = a2;
            a2 = a1;
            a1 = temp;
        }
        static int Par_1(params int[] integers)
        {
            int s = 0;
            foreach(int i in integers)
            {
                s += i;
            }
            return s;
        }
        static int[] Par_2(params int[] integers)
        {
            int s = 0;
            for (int i = 0; i < integers.Length; i ++)
            {
                integers[i] *= 2;
            }
            return integers;
        }



        static void Main(string[] args)
        {
            double a, b, s, r;
            Console.WriteLine("Enter a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = double.Parse(Console.ReadLine());

            Add(a, b, out s, out r);

            Console.WriteLine("Amount: " + s);
            Console.WriteLine("Difference: " + r);

            Console.WriteLine("-------------------------------------------------------------------------------");

            int a1 = 5,
                a2 = 8;
            Console.WriteLine(a1 + " " + a2);
            Replace(ref a1, ref a2);
            Console.WriteLine(a1 + " " + a2);

            Console.WriteLine("-------------------------------------------------------------------------------");

            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(Par_1(arr));

            foreach(int i in Par_2(arr))
            {
                Console.WriteLine(i + " ");
            }




        }
    }
}
