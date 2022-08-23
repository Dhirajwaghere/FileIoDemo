using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Soap;


namespace AdvancedDotnet.DemoIOSystem
{
    [Serializable]
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }
    }
    class Jsonserialization
    {
        

        static void JsonSerializationWrite(Student stud)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\TestFolder\JsonFile.json", FileMode.Create, FileAccess.Write);
                Utf8JsonWriter o = new Utf8JsonWriter(fs);
               
                JsonSerializer.Serialize(o, stud, typeof(Student), null);
                    Console.WriteLine("Json data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void JsonSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\TestFolder\JsonFile.json", FileMode.Open, FileAccess.Read);
              //  Student stud = JsonSerializer.Deserialize<Student>(fs);
               // Console.WriteLine(stud.RollNo);
              //  Console.WriteLine(stud.Name);
              //  Console.WriteLine(stud.Percentage);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
             Student stud = new Student { RollNo = 11, Name = "Ganesh", Percentage = 91.75 };

            JsonSerializationWrite(stud);
            JsonSerializationRead();

        }
    }
}
