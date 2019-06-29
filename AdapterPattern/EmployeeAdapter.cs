using Newtonsoft.Json;
using System;
using System.Xml;

namespace AdapterPattern
{
    public class EmployeeAdapter : EmployeeManager, IEmployee
    {
        public override string GetAllEmployees()
        {
            string returnXml = base.GetAllEmployees();
            Console.WriteLine("------------------:: Before ::------------\n" + returnXml);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(returnXml);
            return JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
