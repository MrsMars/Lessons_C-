using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Патерн проектирования Singleton 

// Singleton - это класс, который должен быть только один в системе или его должно быть только определённое количество экземпляров

namespace Les_39
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton s1 = new Singleton();

            Singleton s1 = Singleton.Initialize();
            Console.WriteLine(s1.GetHashCode());        // 46104728

            Singleton s2 = Singleton.Initialize();
            Console.WriteLine(s2.GetHashCode());        // 46104728
        }
    }
}
