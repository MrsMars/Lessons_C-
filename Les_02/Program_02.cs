using System;

// Arithmetic operations - Арифметические действия
namespace Les_02
{
    class Program_02
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Enter a: ");
            a = double.Parse(Console.ReadLine());          // Parse - transformation at selected type (преобразование в указанный тип)

            Console.WriteLine("Enter b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("\nArithmetic operations: ");
            Console.WriteLine("Amount: " + (a + b));
            Console.WriteLine("Difference: " + (a - b));
            Console.WriteLine("Multiply: " + (a * b));
            Console.WriteLine("Division: " + (a / b));

            Console.ReadKey();
        }
    }
}