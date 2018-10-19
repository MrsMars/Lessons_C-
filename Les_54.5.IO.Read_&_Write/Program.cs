using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_54._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // read
            string path = @"D:\Work\SomeStr_1.txt";

            try
            {
                Console.WriteLine("*** *** *** read all file *** *** ***");
                using (StreamReader sr = new StreamReader(path)) { Console.WriteLine(sr.ReadToEnd()); }

                Console.WriteLine("\n*** *** *** read every string *** *** ***");
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null) { Console.WriteLine(line); }
                }

                Console.WriteLine("\n*** *** *** read every block *** *** ***");
                using(StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    char[] array = new char[4];
                    sr.Read(array, 0, 4);
                    Console.WriteLine(array);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            // write
            string readPath = @"D:\Work\SomeStr_1.txt";
            string writePath = @"D:\Work\SomeStr_2.txt";
            string text = "";

            try
            {
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default)) { text = sr.ReadToEnd(); }
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default)) { sw.WriteLine(text); }
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default)) { sw.WriteLine("Add", " Hello"); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
