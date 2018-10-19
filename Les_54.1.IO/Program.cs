using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IO

namespace Les_54
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach(DriveInfo drive in drives)
            {
                Console.WriteLine("Name: {0}", drive.Name);
                Console.WriteLine("Type: {0}", drive.DriveType);

                if (drive.IsReady)
                {
                    Console.WriteLine("Size: {0}", drive.TotalSize);
                    Console.WriteLine("FreeSpace: {0}", drive.TotalFreeSpace);
                    Console.WriteLine("Label: {0}", drive.VolumeLabel);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
