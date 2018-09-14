using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// ParameterizedThreadStart

namespace Les_51._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter(5, 4);

            Thread thread = new Thread(new ThreadStart(counter.Count));
            thread.Start();

            Console.ReadLine();
        }
    }

    public class Counter
    {
        private int x;
        private int y;

        public Counter(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Count()
        {
            for(int i = 1; i < 9; i++)
            {
                Console.WriteLine("Second thread: {0}", (i * x * y));
                Thread.Sleep(400);
            }
        }
    }
}
