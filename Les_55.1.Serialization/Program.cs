using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// Serialization

namespace Les_55
{
    class Program
    {
        static void Main(string[] args)
        {
            // obj for serialization
            Person person = new Person("Tom", 29, "Some acc");
            Console.WriteLine("Object was created");

            // create BinartFormatter object
            BinaryFormatter formatter = new BinaryFormatter();
            
            // получаем поток, куда будем записывать сериализованный объект
            using(FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);
                Console.WriteLine("Object was serializated");
            }

            // десиарилация
            using(FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                Person newPerson = (Person)formatter.Deserialize(fs);

                Console.WriteLine("Object was deserializated");
                Console.WriteLine("Name: {0} --- Age: {1}", newPerson.Name, newPerson.Age);
            }

            Console.ReadLine();
        }

        [Serializable]
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            [NonSerialized]
            public string accNumber;

            public Person(string name, int age, string acc)
            {
                Name = name;
                Age = age;
                accNumber = acc;
            }
        }
    }
}
