using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Расширяющие методы AND Делегирование(не делегаты)

// Расширяющие методы - позволяют добавлять методы в существующие типы без создания нового типа
// Делегирование - передача собственности

namespace Les_40
{
    class Program
    {
        static void Main(string[] args)
        {
            string p = "JS";
            p.SayHello();           // JS, Hello

            ExtensionClass.SayHello("Python");      // Python, Hello

            string str1 = "we love";
            Console.WriteLine(str1.AddStrings("C#", "C++", "JS", "CSS3", "HTML5"));      // we love C# C++ JS CSS3 HTML5

            string str2 = "I love".AddStrings("C#");
            Console.WriteLine(str2);                                // I love C#
        }
    }
}
