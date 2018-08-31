using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            human.SpeakLoud("hi");
            human.SpeakNormal("I'm ...");
            human.ThinkAboutSmth("Tesla");
        }
    }
}
