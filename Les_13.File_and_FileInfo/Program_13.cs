using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                // for working with files

// File and FileInfo
namespace Les_13
{
    class Program_13
    {
        static void Main(string[] args)
        {
            // FileInfo
            {
                // File     - НЕ наследуется    т.е., чтобы воспользоваться его свойствами достаточно написать имя класса и постаить '.'
                // FileInfo - наследуется       т.е., чтобы воспользоваться его свойствами необходимо создать экземпляр в переменную

                // Console.WriteLine("Specify the path to the file and name:");
                //string path = Console.ReadLine();

                /*{ --- creating---------------------------------------------------------------------------------------------------
                    /FileInfo file = new FileInfo(path);

                    file.Create();
                    Console.WriteLine("I've just created a file called \"new.txt\"...");
                }*/

                /*{// -- is it exests----------------------------------------------------------------------------------------------
                if (file.Exists)
                    {
                        Console.WriteLine("The file is already existed");
                    }
                    else
                    {
                        Console.WriteLine("The file isn't existed");
                    }
                }*/

                /*{//                                      -- copying-------------------------------------------------------------
                    Console.WriteLine("Specify the new path to the file and name:");
                    string path_copy = Console.ReadLine();

                    FileInfo file = new FileInfo(path);
                    file.CopyTo(path_copy);
                    Console.WriteLine("I've just created copy the file to {0}", path_copy);
                }*/

                /*{copying with resetting-----------------------------------------------------------------------------------------
                    Console.WriteLine("Specify the new path to the file and name:");
                    string path_copy = Console.ReadLine();

                    l1: 

                    FileInfo file = new FileInfo(path);
                    try
                    {
                        file.CopyTo(path_copy, false);              // the second option is true/false to replace
                        Console.WriteLine("I've just created copy the file to {0}", path_copy);
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("The file is already existed!\nEnter - to replace, ESC - to copy with new name");

                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.Enter:
                                file.CopyTo(path_copy, true);
                                break;
                            case ConsoleKey.Escape:
                                goto l1;
                        }
                    }
                }*/

                //delete-----------------------------------------------------------------------------------------------------
                /*{
                    string path_copy = Console.ReadLine();

                    FileInfo file = new FileInfo(path);
                    file.Delete();
                }*/

                // move
                /*{
                    Console.WriteLine("Specify the new path to the file and name:");
                    string path_move = Console.ReadLine();

                    FileInfo file = new FileInfo(path_move);
                    file.MoveTo(path_move);
                }*/
            }

            // File
            {/*
                Console.WriteLine("Specify the path to the file and name:");
                string path = Console.ReadLine();
                Console.WriteLine("Specify the path to the new file and name:");
                string path_copy = Console.ReadLine();

                // File.Create(path);       - creating
                File.Copy(path, path_copy, false);

            */
            }


            // propertyes
            {
                Console.WriteLine("Specify the path to the file and name:");
                string path = Console.ReadLine();

                FileInfo file = new FileInfo(path);

                Console.WriteLine("Name " + file.Name);
                Console.WriteLine("Full name " + file.FullName);
                Console.WriteLine("Path " + file.DirectoryName);
                Console.WriteLine("Volume " + file.Length);
                Console.WriteLine("Extention " + file.Extension);
                Console.WriteLine("Data " + file.CreationTime);
            }
        }
    }
}
