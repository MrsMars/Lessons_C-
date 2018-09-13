using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_47
{
    class GenericClass<T> where T : new()
    {
        public T GetNewT()
        {
            return new T();
        }
    }
}
