using System;
using System.IO;
using System.Text;

namespace Les_54._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "hello world";

            // write in file
            using(FileStream fstream = new FileStream(@"D:\Work\SomeStr.dat", FileMode.OpenOrCreate))
            {
                // string to byte
                byte[] input = Encoding.Default.GetBytes(text);

                // write this byte array to the file
                fstream.Write(input, 0, input.Length);
                Console.WriteLine("Text was written to the file");

                // transfer index to the file end -5
                fstream.Seek(-5, SeekOrigin.End);

                byte[] output = new byte[4];
                fstream.Read(output, 0, output.Length);

                string textFromFile = Encoding.Default.GetString(output);
                Console.WriteLine("Text from file {0}", textFromFile);      // worl

                // replace 'world' on 'house'
                string replaceText = "house";
                fstream.Seek(-5, SeekOrigin.End);
                input = Encoding.Default.GetBytes(replaceText);
                fstream.Write(input, 0, input.Length);

                // read this file
                fstream.Seek(0, SeekOrigin.Begin);
                output = new byte[fstream.Length];
                fstream.Read(output, 0, output.Length);
                textFromFile = Encoding.Default.GetString(output);
                Console.WriteLine("Text from file: {0}", textFromFile);     // hello house
            }

            Console.ReadLine();
        }
    }
}
