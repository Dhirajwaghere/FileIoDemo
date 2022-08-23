using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace AdvancedDotnet.DemoIOSystem
{
    class Assignment4
    {
        [Serializable]
        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public int Price { get; set; }
        }

        static void SoapSerializationWrite(Product prod)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\Testfolder1\SoapFile.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, prod);
                Console.WriteLine("Soap data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void SoapSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\Testfolder1\SoapFile.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                Product prod = (Product)sf.Deserialize(fs);
                Console.WriteLine(prod.ProductId);
                Console.WriteLine(prod.ProductName);
                Console.WriteLine(prod.Price);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
             Product prod = new Product { ProductId = 555, ProductName = "DELL", Price = 55000 };
             SoapSerializationWrite(prod);
             SoapSerializationRead();
        }
    }
}
