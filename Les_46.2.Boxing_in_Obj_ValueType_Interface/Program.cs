using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_46
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct mS = new MyStruct();

            // 1й тип упаковки (в object)
            object boxed1 = mS;

            // unboxing
            MyStruct unboxed1 = (MyStruct)boxed1;
            unboxed1.SayHello();                    // Hello


            // 2й тип упаковки (в ValueType)
            ValueType boxed2 = mS;

            // unboxing
            MyStruct unboxed2 = (MyStruct)boxed2;
            unboxed2.SayHello();                    // Hello


            // 3й тип упаковки (в interface)
            IInterface boxed3 = mS;

            // unboxing
            MyStruct unboxed3 = (MyStruct)boxed3;
            unboxed3.SayHello();                    // Hello
            unboxed3.SayGoodbay();                  // Goodbay
        }
    }
}
