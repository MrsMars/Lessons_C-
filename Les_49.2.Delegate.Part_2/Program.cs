using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_49
{
    public delegate int AddDelegate(int a, int b);

    class Mathematics
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();

            AddDelegate aD = new AddDelegate(m.Add);

            int result = aD.Invoke(4, 5);
            Console.WriteLine(result);      // 9
            Console.WriteLine(aD(5, 12));   // 17
        }
    }
}
