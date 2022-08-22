using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdvancedDotnet.DemoIOSystem
{
    class Directroy
    {
        static void createfolder()
        {
            string path = @"D:\CSharp_Microsoft\Testfolder";

            if (Directory.Exists(path))
            {
                Console.WriteLine("Folder is already created");
            }
            else
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Folder is created");
            }
        }


        static void CreateFile()
        {
            string path = @"D:\CSharp_Microsoft\Testfolder\TestFile.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File already exits");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File created");
            }

        }


        static void Main(string[] args)
        {
            createfolder();
            CreateFile();
        }
    }

    
}

