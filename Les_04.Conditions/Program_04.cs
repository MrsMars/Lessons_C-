using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Conditions - Условия if/else
namespace Les_04
{
    class Program_04
    {
        static void Main(string[] args)
        {
            double a;

            a = double.Parse(Console.ReadLine());       // you have to enter ',' like '5,8', because using '5.8' will caose of exception

            if(a > 0)
            {
                Console.WriteLine(a + " > 0");
            }
            else if(a == 0)
            {
                Console.WriteLine(a + " = 0");
            }
            else
            {
                Console.WriteLine(a + " < 0");
            }
        }
    }
}
