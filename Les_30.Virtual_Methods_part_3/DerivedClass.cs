using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_30
{
    class DerivedClass : BaseClass
    {
        public override void VMethod()
        {
            Console.WriteLine("ReinitMethod from deriveedClass");
            base.VMethod();
        }
    }
}
