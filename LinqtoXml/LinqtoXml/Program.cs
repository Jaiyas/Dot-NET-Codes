using System.Xml.Linq;
namespace LinqtoXml
{
    internal class Program
    {
        static void Main(string[] args) {
            XDocument xdoc = XDocument.Load("C:\\hello2.xml");
            var countries = from country in xdoc.Descendants("countries").Elements("country").Attributes("name")
            select country.Value;
            foreach(string i in countries)
            {
                Console.WriteLine(i);
            }
            
    }
    }
}
