using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_28
{
    class DerivedClass : BaseClass
    {
        // Чтобы подтвердить, что мы действительно хотим заменить метод из базового класса методом из произвольного, нужно написать 'new'
        new public void Method()
        {
            Console.WriteLine("Method from derived class");
        }
    }
}
