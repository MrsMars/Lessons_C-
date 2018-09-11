using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_38
{
    static class StaticClass
    {
        public static int field;
        public static double dField;

        public static void GetSum()
        {
            Console.WriteLine(field + dField);
        }

        static StaticClass()
        {
            field = 10;
            dField = 3.5;
        }
    }
}
