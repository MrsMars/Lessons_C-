using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ArrayList

namespace Les_53._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(2.3);      // add double value
            list.Add(55);       // add int
            list.AddRange(new string[] { "Hello", "world" });   // add string array

            foreach (object o in list) { Console.WriteLine(o); }

            list.RemoveAt(0);   // del first el
            list.Reverse();     // reverse array

            Console.WriteLine(list[0]);     // world

            for (int i = 0; i < list.Count; i++) { Console.WriteLine(list[i]); }

            Console.ReadLine();
        }
    }
}
