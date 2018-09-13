using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_47
{
    class DerivedClass : BaseClass
    {
        new public int age { get; }
        new public void Say(string s)
        {
            Console.WriteLine(s.ToUpper());
        }

    }
}
