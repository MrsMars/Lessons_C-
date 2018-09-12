using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CIL. Основные понятия
// чтобы посмотреть файл в cil-виде, нужно открыть командную строку разработчика в пуск / папка ВС и ввести ildasm
// в проге отурыть exe файл

namespace Les_42
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 10;

            Console.WriteLine(a + b);
            Console.ReadKey();
        }
    }
}
