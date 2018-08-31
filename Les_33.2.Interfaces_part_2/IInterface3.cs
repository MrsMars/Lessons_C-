using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_33
{
    interface IInterface3 : IInterface2
    {
        // Широкий интерфейс, тк он самый дочерний

        void Method3();
    }
}
