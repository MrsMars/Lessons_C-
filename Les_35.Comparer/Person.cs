using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_36
{
    class Person : IComparable
    {
        public int age;
        public double height;
        public double weight;

        // def constr
        public Person() { }

        public Person(int age, double height, double weight)
        {
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        // реализация интерфейса
        public int CompareTo(object obj)
        {
            Person p = obj as Person;
            
            if(p != null)
            {
                if (this.age < p.age)
                    return -1;
                else if (this.age > p.age)
                    return 1;
                else
                    return 0;
            }
            else
            {
                throw new Exception("Параметр должен быть типа Person");
            }
        }
    }
}
