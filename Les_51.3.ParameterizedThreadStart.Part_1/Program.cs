using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// ParameterizedThreadStart

namespace Les_51._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 4;

            // new thread
            Thread myThread = new Thread(new ParameterizedThreadStart(Count));
            myThread.Start(number);

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Main thread: {0}", (i * i));
                Thread.Sleep(300);
            }

            Console.ReadLine();
        }

        public static void Count(object x)
        {
            for(int i = 1; i < 9; i++)
            {
                int n = (int)x;

                Console.WriteLine("Second thread: {0}", (i * n));
                Thread.Sleep(400);
            }
        }
    }
}
