using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Exercise3_1_DevelopmentC
{
    class Program
    {
        static void Main(string[] args)

        {

            Program p = new Program();
            p.readXML("Strawberry Belgian Waffles");
        }

        public void readXML(string name) {
            //my local path 
            string filename = "C:\\Users\\evelyne.franco\\source\\repos\\Exercise3-1-DevelopmentC\\Exercise3-1-DevelopmentC\\food.xml";
            XmlDocument xmlDoc = new XmlDocument();
            try {
                   xmlDoc.Load(filename);

            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/breakfast_menu/food");

            foreach (XmlNode node in nodeList)
            {

                if (name.Equals(node.SelectSingleNode("name").InnerText)) {
                    Console.WriteLine("price for {0} is: {1}", name, node.SelectSingleNode("price").InnerText);
                }
            }

            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            


        }
    }
}
