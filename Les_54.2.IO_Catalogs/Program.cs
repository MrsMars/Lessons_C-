using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IO - work with catalogs

namespace Les_54._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = "C:\\";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Inner directories: ");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs) { Console.WriteLine(s); }

                Console.WriteLine();

                Console.WriteLine("Files: ");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files) { Console.WriteLine(s); }
            }

            goto l1;

            // create
            {
                string path = @"C:\SomeDir";
                string subpath = @"program\avalon";

                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                if (!directoryInfo.Exists) { directoryInfo.Create(); }

                directoryInfo.CreateSubdirectory(subpath);
            }

            // get info about dir
            {
                string directName = "C:\\Program Files";

                DirectoryInfo directoryInfo = new DirectoryInfo(directName);

                Console.WriteLine("Название каталога: {0}", directoryInfo.Name);
                Console.WriteLine("Полное название каталога: {0}", directoryInfo.FullName);
                Console.WriteLine("Время создания каталога: {0}", directoryInfo.CreationTime);
                Console.WriteLine("Корневой каталог: {0}", directoryInfo.Root);
            }

            // delete 
            {
                string directName = @"C:\SomeFolder";

                try
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(directName);
                    directoryInfo.Delete(true);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            // or
            {
                string directName = @"C:\SomeFolder";
                Directory.Delete(directName, true);
            }

            // transfer
            {
                string oldPath = @"C:\SomeFolder";
                string newPath = @"C:\SomeDir";

                DirectoryInfo directoryInfo = new DirectoryInfo(oldPath);

                if(directoryInfo.Exists && Directory.Exists(newPath) == false) { directoryInfo.MoveTo(newPath); }
            }

            l1:

            return;
        }
    }
}
