using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Статический конструктор
// не имеют модификаторов доступа и не имеют параметров
// вызывается автоматически для инициализации класса - создаю экземпляр класса или получаю ссылку на статический член

    

namespace Les_37
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass mC1 = new MyClass();



            MyClass.field = 6;
        }
    }
}
