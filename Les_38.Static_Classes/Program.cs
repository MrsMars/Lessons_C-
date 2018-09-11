using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Статический класс - контейнер, содержащий в себе только статические члены

namespace Les_38
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass.GetSum();       // 13.5

            StaticClass.field = 30;
            StaticClass.dField = 1.5;

            StaticClass.GetSum();       // 31.5
        }
    }
}
