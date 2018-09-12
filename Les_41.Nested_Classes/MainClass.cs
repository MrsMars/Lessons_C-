using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_41
{
    class MainClass
    {
        public string Name { get; set; }
        public void MMethod()
        {
            Console.WriteLine("Method from MainClass");
        }

        public class NestedClass
        {
            public void Method()
            {
                Console.WriteLine("Method from NestedClass");
            }
        }

        public class DerivedNestedClass : BaseClass, ISpeech
        {
            public DerivedNestedClass(string s)
            {
                field = s;
            }

            private string field;

            public string GetField()
            {
                return field;
            }

            public void Say(string s)
            {
                Console.WriteLine(s);
            }
            public void Shout(string s)
            {
                Console.WriteLine(s + " said loudly");
            }
        }
    }
}
