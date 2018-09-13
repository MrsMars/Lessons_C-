using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Boxing // Unboxing. Упаковка - преобразование структурного типа в ссылочный тип

namespace Les_46
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            // boxing   -   создали переменную типа object и записали в неё ссылку на объект, в котором содержится значение переменно i 
            object obj = i;

            // unboxing
            int j = (int)obj;

            Console.WriteLine(j);       // 10
        }
    }
}
