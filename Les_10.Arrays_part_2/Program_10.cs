using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Circle 'foreach'
namespace Les_10
{
    class Program_10
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[5];
            int[] a2 = new int[] { 343, 343, 056, 92, 9323 };
            int[] a3 = new int[5] { 1, 45, 94, 9, 5 };

            double[] d = new double[] { 2.8, 7.9 };

            string[] s = new string[] { "pool", "red", "men" };

            char[] c = new char[5] { '6', '_', '*', 'g', 'd' };

            // 'foreach is only for reading
            foreach(int i in a2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("/n");

            foreach (string str in s)
            {
                Console.Write(str + " ");
            }
        }
    }
}
