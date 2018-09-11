using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_39
{
    class Singleton
    {
        // приватное поле класса типа Singleton
        private static Singleton single = null;

        // защищённый конструтор
        protected Singleton()
        {

        }
        // Фабричный метод
        public static Singleton Initialize()
        {
            if (single == null)
                single = new Singleton();

            return single;
        }
    }
}
