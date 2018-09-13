using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_46
{
    struct MyStruct : IInterface
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public void SayGoodbay()
        {
            Console.WriteLine("Goodbay");
        }
    }
}
