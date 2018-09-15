using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LinkedList<T>    - каждый элемент хранит ссылку на предыдущий и следующий элемент одновременно

namespace Les_53._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // int
            LinkedList<int> numbers = new LinkedList<int>();

            numbers.AddLast(1);     // add last and first at the same time cause capacity == 1
            numbers.AddFirst(2);
            numbers.AddAfter(numbers.Last, 3);  // add 3 after last     

            foreach (int i in numbers) { Console.WriteLine(i); }        // : 2, 1, 3

            // class
            LinkedList<Person> persons = new LinkedList<Person>();

            LinkedListNode<Person> tom = persons.AddLast(new Person() { Name = "Tom" });

            persons.AddLast(new Person() { Name = "John" });
            persons.AddFirst(new Person() { Name = "Bill" });

            Console.WriteLine(tom.Previous.Value.Name);     // previously tom   - Bill
            Console.WriteLine(tom.Next.Value.Name);         //                  - John
            Console.WriteLine(tom.GetType());
  

            Console.ReadLine();
        }

        class Person
        {
            public string Name { get; set; }
        }
    }
}
