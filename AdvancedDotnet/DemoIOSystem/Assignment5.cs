using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace AdvancedDotnet.DemoIOSystem
{
    class Assignment5
    {
        [Serializable]
        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public int Price { get; set; }
        }

        static void XmlSerializationWrite(Product prod)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\Testfolder1\XmlFile.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Product));
                xs.Serialize(fs, prod);
                Console.WriteLine("XML data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void XmlSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\Testfolder1\XmlFile.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Product));
                Product prod = (Product)xs.Deserialize(fs);
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
            XmlSerializationWrite(prod);
            XmlSerializationRead();
        }
    }
}
