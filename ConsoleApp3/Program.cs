using System;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", "../../library.xsd");

            XDocument Doc = XDocument.Load("../../library.xml");
            bool errors = false;
            Doc.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });
            Console.WriteLine("Valid? {0}", errors ? "Nope" : "Yep");

            Console.ReadKey();
        }
        
    }
}
