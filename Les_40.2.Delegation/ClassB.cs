using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_40
{
    class ClassB
    {
        // создаём экземпляр класса А по слабой ссылке и на нём вызовем метод
        public void DoSomth()
        {
            new ClassA().DoSomth();
        }
    }
}
