using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// delegate - специальный объект, хранящий в себе указатель на метод (указатель на первый адрес байта, с которого начинается метод в памяти)

namespace Les_49
{
    public delegate void MyDelegate();      // делегат

    class SomeClass
    {
        public static void Method()
        {
            Console.WriteLine("Hello!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate mD = new MyDelegate(SomeClass.Method);       // создаём экземпляр делегата и передаём в конструктор класса делегата метод Method из SomeClass

            mD.Invoke();        // or 'mD()'     запускает выполнение сообщённого метода
        }
    }
}
