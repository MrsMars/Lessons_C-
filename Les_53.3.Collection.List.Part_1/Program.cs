using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_53._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // int 
            List<int> numbers = new List<int>() { 1, 2, 3, 45 };

            numbers.Add(6);
            numbers.AddRange(new int[] { 7, 8, 9 });
            numbers.Insert(0, 777);     // add 777 on the first place
            numbers.RemoveAt(1);        // del 2nd el

            foreach (int i in numbers) { Console.WriteLine(i); }

            // class
            List<Person> people = new List<Person>(3);      // 3 - size (capacity)

            Console.WriteLine(people.Capacity);
            people.Capacity = 4;
            Console.WriteLine(people.Capacity);

            people.Add(new Person() { Name = "Tom" });
            people.Add(new Person() { Name = "John" });
        }

        class Person
        {
            public string Name { get; set; }
        }
    }
}
