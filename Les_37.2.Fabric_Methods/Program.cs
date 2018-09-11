using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Фабричный метод возвращает экземпляр класса

namespace Les_37
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass myClass = AbstractClass.Create();
            // создали экземпляр класса и привели его к базовому типу

            myClass.Method();
        }
    }
}
