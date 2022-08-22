using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdvancedDotnet.DemoIOSystem
{
    class Assignment1
    {
        public class Dept
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Fees { get; set; }
        }

        static void WriteToFile(Dept dept)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\Testfolder1", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(dept.Id);
                bw.Write(dept.Name);
                bw.Write(dept.Fees);
                bw.Close();
                fs.Close();
                Console.WriteLine("Data added to file");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void ReadFromFile()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\Testfolder1", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                Console.WriteLine(br.ReadInt32()); 
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadInt32());
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static void Main(string[] args)
        {
            Dept dept = new Dept { Id = 1, Name = "Dhiraj", Fees = 100001 };
            WriteToFile(dept);
            //ReadFromFile();
        }
    }
}
