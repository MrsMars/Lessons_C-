using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// Threading and del ThreadStart

namespace Les_51
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new thread
            Thread myThread = new Thread(new ThreadStart(Count));
            // or Thread myThread = new Thread(Count);

            // start the thread
            myThread.Start();

            for(int i = 1; i < 9; i++)
            {
                Console.WriteLine("Main thread: ");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }
        }

        public static void Count()
        {
            for(int i = 1; i < 9; i++)
            {
                Console.WriteLine("Second thread: ");
                Console.WriteLine(i * i);
                Thread.Sleep(400);
            }
        }
    }
}
