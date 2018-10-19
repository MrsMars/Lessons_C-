using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// File & FileInfo

    /*  FileInfo
     * CopyTo(path) - copy file to new path
     * Create()     - create file
     * Delete()     - delete file
     * MoveTo(path) - move to new path
     * Directory    - get base dir
     * DirectoryName - get full path
     * Exists       - is file exists
     * Length       - file length
     * Name         - get file name
     * FullName     - full file name
     */

    /* File
     * Copy()
     * Create()
     * Delete()
     * Move
     * Exists(file)
     */

namespace Les_54._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // goto l1;

            string path = @"D:\Work\SomeStr.txt";
            string newPath = @"D:\SomeStr.txt";

            FileInfo fileInfo = new FileInfo(path);

            // create
            {
                if (!fileInfo.Exists)
                {
                    fileInfo.Create();
                    Console.WriteLine("Object was created");
                }
            }

            // get info
            {
                if (fileInfo.Exists) {
                    Console.WriteLine("Name: {0}", fileInfo.Name);
                    Console.WriteLine("Full name: {0}", fileInfo.FullName);
                    Console.WriteLine("Extention: {0}", fileInfo.Extension);
                    //Console.WriteLine("Length: {0)", fileInfo.Length);
                    //Console.WriteLine("Directory: {0)", fileInfo.Directory);
                    //Console.WriteLine("Directory name: {0)", fileInfo.DirectoryName);
                    Console.WriteLine("Creation time: {0}", fileInfo.CreationTime);
                }
            }

            // copy
            {
                if (fileInfo.Exists)
                {
                    fileInfo.CopyTo(newPath, true);
                    Console.WriteLine("Object was copying to {0}", newPath);
                }
            }
            
            // delete
            {
                if (fileInfo.Exists)
                {
                    fileInfo.Delete();
                    Console.WriteLine("Object was deleted from {0}", path);
                }
            }

            // transfer
            {
                FileInfo fileInfo2 = new FileInfo(newPath);

                if (fileInfo2.Exists)
                {
                    fileInfo2.MoveTo(path);
                    Console.WriteLine("Object was transfered to {0}", path);

                    fileInfo2.Delete();
                    Console.WriteLine("Object was deleted from {0}", path);
                }
            }

            l1:

            return;
        }
    }
}
