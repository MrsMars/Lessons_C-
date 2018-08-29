using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Вирутальные методы и к.с. base

namespace Les_30
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();

            derivedClass.VMethod();         // ReinitMethod from deriveedClass
                                            // VMethod ftom base class
        }
    }
}
