using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; //Reference for the XmlReader-class

namespace Read_SMHI_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"c:\data.xml");

            //XmlNode node = doc.DocumentElement.SelectSingleNode("/root/timeSeries/parameters");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string text = node.InnerText; //or loop through its children as well
            }
        }
    }
}
