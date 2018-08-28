using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_27
{
    class BaseClass
    {
        public string Firm { get; set; } = "Unknown firm";
        public string Material { get; set; } = "Unknown material";

        public BaseClass()
        {
            Console.WriteLine("Base constructor without any parameters");
            Console.WriteLine(new string('-', 40));
        }
        public BaseClass(string firm, string material)
        {
            Console.WriteLine("Base constructor with string parameters");
            Console.WriteLine(new string('-', 40));

            Firm = firm;
            Material = material;
        }


    }
}
