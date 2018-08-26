using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Необязательые и именованные параметры
namespace Les_17
{
    class Program_17
    {
        // if there is a 'name', it will be a field
        // Необязательные
        static int Add(int a, int b, int c = 0, int d = 0)
        {
            // if isn't 'c' and 'd', than 'c' and 'd' = 0
            return a + b + c + d;
        }

        //  Именованные
        static void Person(string name, int date, string gender)
        {
            Console.WriteLine("Name {0}\ndate {1}\ngender {2}", name, date, gender);
            // there is 'name' is a local value
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));           // 3
            Console.WriteLine(Add(1, 2, 3));        // 6
            Console.WriteLine(Add(1, 2, 3, 4));     // 10

            string newName = Console.ReadLine();
            int newDate = int.Parse(Console.ReadLine());
            string newGender = Console.ReadLine();

            Person(newName, newDate, newGender);
            Person(newGender, newDate, newName);

            Person(date: newDate, name: newName, gender: newGender);
        }
    }
}
