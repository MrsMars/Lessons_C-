using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Collections

namespace Les_53
{
    class Program
    {
        static void Main(string[] args)
        {
            // необобщённая коллекция ArrayList
            ArrayList objectList = new ArrayList() { 1, 2, "string", 'c', 2.0f };

            object obj = 45.8;
            objectList.Add(obj);
            objectList.Add("string2");
            objectList.RemoveAt(0);         // delete first element

            foreach(object o in objectList) { Console.WriteLine(o); }
            Console.WriteLine("Общее число элементов коллекции: {0}", objectList.Count);

            // обобщённая коллекция List
            List<string> countries = new List<string>() { "USA", "UK", "France", "Italia", "China" };
            countries.Add("German");
            countries.RemoveAt(1);      // delete second element

            foreach (string s in countries) { Console.WriteLine(s); }
            Console.WriteLine("Общее число элементов коллекции: {0}", countries.Count);

            Console.ReadLine();
        }
    }
}
