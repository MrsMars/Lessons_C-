using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_40
{
    static class ExtensionClass
    {
        // этим методом мы расширим тип string
        public static void SayHello(this string s)
        {
            Console.WriteLine($"{s}, Hello");
        }

        public static string AddStrings(this string s, params string[] strings)
        {
            for(int i = 0; i < strings.Length; i++)
            {
                s += $" {strings[i]}";
            }
            return s;
        }
    }
}
