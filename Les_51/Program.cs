using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// Threading

namespace Les_51
{
    class Program
    {
        static void Main(string[] args)
        {
            // get this thread
            Thread t = Thread.CurrentThread;

            // thread name
            Console.WriteLine("Thread name: {0}", t.Name);      // 
            t.Name = "Main method";
            Console.WriteLine("Thread name: {0}", t.Name);      // Thread name: Main method

            Console.WriteLine("Is it working: {0}", t.IsAlive);                 // Is it working: True
            Console.WriteLine("Is bachground thread: {0}", t.IsBackground);     // Is bachground thread: False
            Console.WriteLine("Thread priority: {0}", t.Priority);              // Thread priority: Normal  ( Lowest / BelowNormal / Normal / AboveNormal / Highest )
            Console.WriteLine("Thread state: {0}", t.ThreadState);              // Thread state: Running 

                                                                                /* Aborted: поток остановлен, но пока еще окончательно не завершен
                                                                                 * AbortRequested: для потока вызван метод Abort, но остановка потока еще не произошла
                                                                                 * Background: поток выполняется в фоновом режиме
                                                                                 * Running: поток запущен и работает(не приостановлен)
                                                                                 * Stopped: поток завершен
                                                                                 * StopRequested: поток получил запрос на остановку
                                                                                 * Suspended: поток приостановлен
                                                                                 * SuspendRequested: поток получил запрос на приостановку
                                                                                 * Unstarted: поток еще не был запущен
                                                                                 * WaitSleepJoin: поток заблокирован в результате действия методов Sleep или Join
                                                                                 */
            Console.WriteLine(Thread.CurrentThread);

            // get application domain
            Console.WriteLine("Application domain: {0}", Thread.GetDomain().FriendlyName);      // Application domain: Les_51.exe

            Console.ReadLine();
        }
    }
}
