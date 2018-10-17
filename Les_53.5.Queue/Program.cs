using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Queue<>  - очередь

namespace Les_53._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // int  ///////////////////////////////////////////////////
            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(3);     // queue 3
            numbers.Enqueue(5);     // queue 3, 5
            numbers.Enqueue(8);     // queue 3, 5, 8

            // get first el with extraction
            int queueElement = numbers.Dequeue();   // new queue is 5,8
            Console.WriteLine(queueElement);

            // Person   ///////////////////////////////////////////////
            Queue<Person> persons = new Queue<Person>();

            persons.Enqueue(new Person() { Name = "Tom" });
            persons.Enqueue(new Person() { Name = "Bill" });
            persons.Enqueue(new Person() { Name = "John" });

            // get first el without extraction
            Person pp = persons.Peek();
            Console.WriteLine(pp.Name);

            Console.WriteLine("There are {0} people in the queue", persons.Count);

            // There are Tom, Bill, John in queue
            foreach (Person p in persons) { Console.WriteLine(p.Name); }

            // get first el with extraction - Tom
            Person person = persons.Dequeue();      // there are Bill and John
            Console.WriteLine(person.Name);

            Console.ReadLine();            
        }

        class Person { public string Name { get; set; } }
    }
}
