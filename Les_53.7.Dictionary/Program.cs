using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dictionary<T, V>

namespace Les_53._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // int string   //////////////////////////////////////////////////////////////////////////////////////////////////////
            Dictionary<int, string> countries = new Dictionary<int, string>(5);

            countries.Add(1, "Russia");
            countries.Add(3, "Great Britian");
            countries.Add(2, "USA");
            countries.Add(4, "France");
            countries.Add(5, "China");

            foreach (KeyValuePair<int, string> keyValue in countries) { Console.WriteLine(keyValue.Key + " - " + keyValue.Value); }

            string country = countries[4];
            countries[4] = "Spain";

            countries.Remove(2);        // del

            // char class /////////////////////////////////////////////////////////////////////////////////////////////////////////
            Dictionary<char, Person> people = new Dictionary<char, Person>();

            people.Add('b', new Person() { Name = "Bill" });
            people.Add('t', new Person() { Name = "Tom" });
            people.Add('j', new Person() { Name = "John" });
            // or
            people['a'] = new Person() { Name = "Alice" };

            foreach (KeyValuePair<char, Person> keyValue in people) { Console.WriteLine(keyValue.Key + " - " + keyValue.Value); }

            // excess - перебор
            foreach (char c in people.Keys) { Console.WriteLine(c); }

            // excess 
            foreach (Person p in people.Values) { Console.WriteLine(p); }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Dictionary<string, string> countries_2 = new Dictionary<string, string>
            {
                {"France", "Paris" },
                {"Great Britian", "London" },
                {"USA", "Washington" }
            };
            foreach (var pair in countries_2) { Console.WriteLine("{0} - {1}", pair.Key, pair.Value); }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Dictionary<string, string> countries_3 = new Dictionary<string, string>
            {
                ["France"] = "Paris",
                ["Great Britian"] = "London",
                ["USA"] = "Washington"
            };
            foreach (var pair in countries_3) { Console.WriteLine("{0} - {1}", pair.Key, pair.Value); }
        }
    }
    class Person { public string Name { get; set; } }
}
