using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Автоматические свойства - используются, если нам не нужна дополнительна логика и нас устроит укороченная форма

namespace Les_22
{
    class Program_22
    {
        static void Main(string[] args)
        {
            Hummer hummer = new Hummer();
            hummer.Firm = "SomeFirm";
            hummer.Material = "tree";

            Console.WriteLine(hummer.Firm + ", " + hummer.Material);
        }
    }
}
