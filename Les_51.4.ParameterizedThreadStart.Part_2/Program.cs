using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// ParameterizedThreadStart

namespace Les_51._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.x = 4;
            counter.y = 5;

            Thread myThread = new Thread(new ParameterizedThreadStart(Count));
            myThread.Start(counter);

            Console.ReadLine();
        }

        public static void Count(object obj)
        {
            for(int i = 1; i < 9; i++)
            {
                Counter c = (Counter)obj;
                Console.WriteLine("Second thread: {0}", (i * c.x * c.y));
            }
        }
    }

    public class Counter
    {
        public int x;
        public int y;
    }
}
