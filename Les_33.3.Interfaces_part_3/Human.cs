using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_33
{
    class Human : IThinking, ISpeaking 
    {
        public void SpeakLoud(string s)
        {
            Console.WriteLine("Speaking loud - {0}", s);
        }
        public void SpeakNormal(string s)
        {
            Console.WriteLine("Speak normal - {0}", s);
        }

        public void ThinkAboutSmth(string s)
        {
            Console.WriteLine("Thinking about - {0}", s);
        }
    }
}
