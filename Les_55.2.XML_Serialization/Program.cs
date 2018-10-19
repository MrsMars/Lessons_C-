using System;
using System.IO;
using System.Xml.Serialization;

// XML serialization

namespace Les_55._2
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Tom", 29);
            Console.WriteLine("Object was created");

            // transfer type of class to constructor
            XmlSerializer formatter = new XmlSerializer(typeof(Person));

            // get thread where we will write our serialized object
            using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);
                Console.WriteLine("Object was serialized");
            }

            /*
                <?xml version="1.0"?>
                <Person xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
                    <Name>Tom</Name>
                    <Age>29</Age>
                </Person>
            */

            // deserialize
            using(FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            {
                Person newPerson = (Person)formatter.Deserialize(fs);
                Console.WriteLine("Object was deserialized");
                Console.WriteLine("Name: {0} --- Age: {1}", newPerson.Name, newPerson.Age);
            }

            Console.ReadLine();
        }
    }
}
