﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Интерфейсы. Секреты использования

/*
 *      1. Реализация одноименных методов
 *          "Явное указание имени интерфейса в имени метода, которому он принадлежит
 *          1. Такие методы при реализации не имеют модификатора доступа и являются private
 *          2. Для использования одноименных методов необходимо приведение к базовому типу (UpCast), иначе методы недоступны
 *      2. Наследование интерфейса от интерфейса, у которых совпадают имена методов
 *          1. При реализации используется техника "реализация одноименных методров"
 *      3. Наследование интерфейса от интерфейса, у которых совпадают имена методов
 *          "техника объединения реализации одноименных абстрактных членов"
 *      4. Наследование абстрактных классов от интерфейсов
 *          1. Замещение абстрактного метода из интерфейса в абстрактном классе обязательно
 *          2. Реализация абстрактного метода в конкретном классе обязательна
 *      5. Наследование от класса и интерфейса, у которых совпадают сигнатуры методов
 *          1. Реализация интерфейса необязательна т.к. сигнатуры методов в классе и интерфейсе совпадают
 */

namespace Les_34
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            // недоступны методы интерфейсов тк в derivedClass они private

            IInterfaceA derivedClassUpToA = derivedClass;
            derivedClassUpToA.Method();

            IInterfaceB derivedClassUpToB = derivedClass as IInterfaceB;
            derivedClassUpToB.Method();
        }
    }
}
