using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Field - это переменная, объявленная непосредственно в классе или структуре
namespace Les_14
{
    class Program_14
    {
        public int a;
        private int b;
        int c;
        protected int d;
        internal int e;
        protected internal int f;

        public int a1;
        static public int a2;
        static public int a3;


        static void Main(string[] args)
        {
            // чтобы обратиться к 'a', нужно создать экземпляр класса Program_14
            Program_14 p = new Program_14();

            p.a = int.Parse(Console.ReadLine());
            p.b = int.Parse(Console.ReadLine());
            p.c = int.Parse(Console.ReadLine());
            p.d = int.Parse(Console.ReadLine());
            p.e = int.Parse(Console.ReadLine());
            p.f = int.Parse(Console.ReadLine());

            Console.WriteLine("\npublic int a = {0}\nprivate int b = {1}\nint c = {2}\nprotected int d = {3}\ninternal int e = {4}\nprotected internal int f = {5}\n", 
                                p.a, p.b, p.c, p.d, p.e, p.f);


            p.a1 = int.Parse(Console.ReadLine());               // - обращаемся, создав экземпляр класса
            Program_14.a2 = int.Parse(Console.ReadLine());      // указываем имя класса
            a3 = int.Parse(Console.ReadLine());                 // ИЛИ т.к она объявлена в том же классе, в котором и вызывается, то имя может быть упрощено

            Console.WriteLine("\npublic int a1 = {0}\nstatic public int a2 = {1}\nstatic public int a3 = {2}\n", p.a1, Program_14.a2, a3);


        }
    }
}
