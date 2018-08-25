using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// exceptions treatment try - обработка исключений
namespace Les_08
{
    class Program_08
    {
        static void Main(string[] args)
        {
            /* types of exceptions:
             *
             *  'Exception'                 - is a basic type
             *  'FormatException'           - invalid data format
             *  'NullReferenceException'    - в экземплре объекта не задана ссылка на объект
             *  'IndexOutOfRangeException'  - выход за пределы массива
             *  'FileNotFoundException'     - файл не найден по указанному адресу
             *  'DivivdeByZerroException    - деление на ноль
             *  
             */

            Console.Title = "Calculator";

            double a, b;
            char c;

        l1:

            try
            {
                Console.WriteLine("Enter a: ");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter a sign: ");
                c = char.Parse(Console.ReadLine());

                Console.WriteLine("Enter b: ");
                b = double.Parse(Console.ReadLine());

                switch (c)
                {
                    case '+':
                        Console.WriteLine("Amount: " + (a + b) + '\n');
                        goto l1;
                    case '-':
                        Console.WriteLine("Difference: " + (a - b) + '\n');
                        goto l1;
                    case '*':
                        Console.WriteLine("Muliply: " + (a * b) + '\n');
                        goto l1;
                    case '/':
                        Console.WriteLine("Division: " + (a / b) + '\n');
                        goto l1;
                    default:
                        Console.WriteLine("Error" + '\n');
                        goto l1;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
                goto l1;
            }
            finally
            {
                Console.WriteLine("_______________________");
            }

        }
    }
}
