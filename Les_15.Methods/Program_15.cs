using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Methods
namespace Les_15
{
    class Program_15
    {
        public void Add_1(int int_a, int int_b)
        {
            Console.WriteLine(int_a + int_b);
        }
        static public void Add_2(int int_a, int int_b)
        {
            Console.WriteLine(int_a + int_b);
        }

        public int Add_3(int int_a, int int_b)
        {
            return int_a + int_b;
        }
        static public int Add_4(int int_a, int int_b)
        {
            return int_a + int_b;
        }

        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Enter first number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("public void Add_1: ");

            Program_15 p = new Program_15();            // тк функция 1 нестатическая, то обратиться к ней можно только создав экземплр класса
            p.Add_1(a, b);

            Console.Write("static public void Add_2: ");
            Program_15.Add_2(a, b);                     // or just 'Add_2', тк они находятся в одном классе

            Console.WriteLine("public int Add_3: " + p.Add_3(a, b));
            p.Add_3(a, b);

            Console.WriteLine("static public int Add_4: " + Add_4(a, b));       // или Program_15.Add_2(a, b), если бы они были в разных классах
            
        }
    }
}
