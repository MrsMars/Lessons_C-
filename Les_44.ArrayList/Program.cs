using System;
using System.Collections.Generic;
using System.Collections;   // for ArrayList
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// нетипизированные (гетерогенные) коллекции - ArrayList. Может содержать элементы любого типа + Он поддерживает изменение размера и набор является индексированным

namespace Les_44
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();       // 1я перегрузка

            list.Add(14);
            list.Add("hello");
            list.Add('!');

            // когда мы добавляем элемент в массив, то он приводится к типу obj - boxing
            foreach(object o in list)
            {
                Console.Write(o + "  ");        //  14  hello  !
            }

            Console.WriteLine("\n" + list.Count);       // 3

            Console.WriteLine("\n-----------------------------------------------------------\n");

            // addRange - добавить набор ////////////////////////////////////////////////////////////////////

            list.AddRange(new double[] { 2.4, 1.98, 6.45 });        // 14  hello  !  2,4  1,98  6,45

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");

            // insert вставить в /////////////////////////////////////////////////////////////////////////////

            list.Insert(2, "world");        // 14  hello  world  !  2,4  1,98  6,45

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");

            // insert вставить набор в ////////////////////////////////////////////////////////////////////////

            ArrayList sList = new ArrayList
            {
                'l', 'o', 'v', 'e'
            };

            list.InsertRange(list.Count - 1, sList);        // 14  hello  world  !  2,4  1,98  l  o  v  e  6,45

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");

            // indexof ищет элемент до первого соответствия

            list.Insert(8, "hello");

            Console.WriteLine(list.IndexOf("hello"));       // 1
            Console.WriteLine(list.LastIndexOf("hello"));   // 8

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");

            // Remove - очистить 1 объект //////////////////////////////////////////////////////////////////////

            list.Remove("hello");       // 14  world  !  2,4  1,98  l  o  hello  v  e  6,45

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");

            // RemoveAt - очистить 1 объект по индексу /////////////////////////////////////////////////////////

            list.RemoveAt(list.IndexOf("hello"));       // 14  world  !  2,4  1,98  l  o  v  e  6,45

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");

            // RemoveRange - очистить n объектов по индексу  и количеству ///////////////////////////////////////

            list.RemoveRange(3, 2);         // 14  world  !  l  o  v  e  6,45

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");

            // contains - содержит ли список элемент

            list.Add(90);
            list.Insert(3, 90);
            list.Insert(6, 90);         // 14  world  !  90  l  o  90  v  e  6,45  90

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }

            Console.WriteLine("\n---- --- --- --- --- --- --- --- ---\n");

            while (list.Contains(90))
            {
                list.Remove(90);
            }                                       // 14  world  !  l  o  v  e  6,45

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");

            // работа с интерфейсом ienumerate. инумератор - курсор, с помощью которого можно ходить по значениям

            IEnumerator en = list.GetEnumerator();

            while (en.MoveNext())
            {
                Console.Write(en.Current + ", ");
            }                                           // 14, world, !, l, o, v, e, 6,45,
        }
    }
}
