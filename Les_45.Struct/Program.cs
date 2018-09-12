using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Структуры - для хранения маленьких данных 

namespace Les_45
{
    struct Rectangle
    {
        public int a;
        public int b;

        static Rectangle()
        {
            Console.WriteLine("Hello");
        }
    
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static int GetS(Rectangle rect)
        {
            return rect.a * rect.b;
        }
        public int GetP()
        {
            return 2 * (a + b);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            Console.WriteLine(rect1.a + " " + rect1.b);       // 0 0

            Console.WriteLine("\n-----------------------------------------------------------\n");

            Rectangle rect2;

            rect2.a = 10;
            rect2.b = 9;

            Console.WriteLine(rect2.a + " " + rect2.b);       // 10 9

            Console.WriteLine("\n-----------------------------------------------------------\n");

            Rectangle rect3 = rect2;
            rect3.a = 3;

            Console.WriteLine(rect3.a + " " + rect3.b);       // 3 9

            Console.WriteLine("\n-----------------------------------------------------------\n");

            Rectangle rect4 = new Rectangle(7, 8);          // Hello

            Console.WriteLine(rect4.a + " " + rect4.b);       // 7 8

            Console.WriteLine("\n-----------------------------------------------------------\n");

            Console.WriteLine(Rectangle.GetS(rect3));       // 27
            Console.WriteLine(rect3.GetP());                // 24

            Console.WriteLine(Rectangle.GetS(rect4));       // 56
            Console.WriteLine(rect4.GetP());                // 30

            Console.WriteLine("\n-----------------------------------------------------------\n");
        }
    }
}
