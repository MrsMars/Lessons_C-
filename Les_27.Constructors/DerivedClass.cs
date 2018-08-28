using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_27
{
    class DerivedClass : BaseClass
    {
        // конструктор (по умолчанию) производного класса, который будет вызывать конструктор базового класса
        public DerivedClass() : base()
        {
            Console.WriteLine("Derived constructor without any parameters\n{0}, {1}", Firm, Material);
            Console.WriteLine(new string('-', 40));
        }
        public DerivedClass(string firm, string material) : base(firm, material)
        {
            Console.WriteLine("Derived constructor with string parameters\n{0}, {1}", Firm, Material);
            Console.WriteLine(new string('-', 40));
        }
    }
}
