using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// struct
namespace Les_12
{
    class Program_12
    {
        struct Student
        {
            public string name;
            public int date;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--- --- --- Single struct --- --- ---");

            Student st = new Student();
            Console.WriteLine("Enter student's name:");
            st.name = Console.ReadLine();
            Console.WriteLine("Enter his(her) birthday:");
            st.date = int.Parse(Console.ReadLine());

            Console.WriteLine("\nName: {0}\nData: {1}", st.name, st.date);

            Console.WriteLine("--- --- --- Struct array --- --- ---");

            Console.WriteLine("Enter the array size");
            int n = int.Parse(Console.ReadLine());

            Student[] stArr = new Student[n];

            for(int i = 0; i < stArr.Length; i++)
            {
                Console.WriteLine("Enter student's name:");
                stArr[i].name = Console.ReadLine();
                Console.WriteLine("Enter his(her) birthday:");
                stArr[i].date = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < stArr.Length; i++)
            {
                Console.WriteLine("\n___________________________" +
                                    "\nStudent #{2}" +
                                    "\nName: {0}\nData: {1}", stArr[i].name, stArr[i].date, i);
            }

            Console.ReadKey();
        }
    }
}
