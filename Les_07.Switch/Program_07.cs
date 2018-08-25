using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// operator 'switch' and 'goto'
namespace Les_07
{
    class Program_07
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";

            double a, b;
            char c;

            l1:

            Console.WriteLine("Enter a: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a sign: ");
            c = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            b = double.Parse(Console.ReadLine());
        
            switch (c)
            {
                case '+':
                    Console.WriteLine("Amount: " + (a + b) + '\n');
                    goto l1;
                case '-':
                    Console.WriteLine("Difference: " + (a - b) + '\n');
                    goto l1;
                case '*':
                    Console.WriteLine("Muliply: " + (a * b) + '\n');
                    goto l1;
                case '/':
                    Console.WriteLine("Division: " + (a / b) + '\n');
                    goto l1;
                default:
                    Console.WriteLine("Error" + '\n');
                    goto l1;
            }
            Console.ReadKey();
        }
    }
}
