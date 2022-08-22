using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdvancedDotnet.DemoIOSystem
{
    class Assignment2
    {
        static void WriteToFileUsingStream()
        {
           
            try
            {
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\Testfolder\TextDoc.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                string str = Console.ReadLine();
                sw.Close();
                fs.Close();
                Console.WriteLine("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ReadFromFileUsingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\Testfolder\TextDoc.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {

            WriteToFileUsingStream();

            ReadFromFileUsingStream();
        }
    }
}
