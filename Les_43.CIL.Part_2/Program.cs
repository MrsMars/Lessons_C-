using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Les_43.TextFile1;
using System.Reflection;

// CIL. будем реализовывать статический метод в интерфейсе с помощью cil

namespace Les_43
{
    class Program
    {
        static void Main(string[] args)
        {
            IMagic.GetMagic();

            Type type = typeof(IMagic);

            MethodInfo method = type.GetMethod(nameof(IMagic.GetMagic));

            method.Invoke(null, null);
        }
    }
}
