using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_26
{
    class BaseClass
    {
        public string pubField = "BaseClass.pubField";
        private string prField = "BaseClass.prField";
        protected string protField = "BaseClass.protField";

        public void Method()
        {
            Console.WriteLine("BasicMethod()");
        }
    }
}
