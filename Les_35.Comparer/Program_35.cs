using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Компараторы - осуществляют возможность сортировки для каких-либо объектов за счёт того, что в классах реализованы интерфейсы IComparable и IComparer

namespace Les_36
{
    class Program
    {
        static void Main(string[] args)
        {
            // array of Person
            Person[] mas = new Person[10];

            Random r = new Random();

            for(int i = 0; i < mas.Length; i++)
            {
                mas[i] = new Person(r.Next(1, 95), r.Next(30, 190), r.Next(20, 95));
                Console.WriteLine(mas[i].age + " " + mas[i].height + " " + mas[i].weight);
            }

            Console.WriteLine("\n--------------- сортировка массива --------------\n");

            //5/ Array.Sort(mas);
            Array.Sort(mas, new HeightComparer());

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i].age + " " + mas[i].height + " " + mas[i].weight);
            }
        }
    }
}
