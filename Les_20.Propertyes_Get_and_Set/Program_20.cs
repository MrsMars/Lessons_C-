using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Propertyes get and set

namespace Les_20
{
    class Program_20
    {
        static void Main(string[] args)
        {
            Hummer hummer = new Hummer();
            hummer.Material = Console.ReadLine();

            Console.WriteLine(hummer.Material);     // tree or ''
        }
    }
}
