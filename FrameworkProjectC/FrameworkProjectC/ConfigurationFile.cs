using System;
using System.Xml;

namespace FrameworkProjectC
{
    public class ConfigurationFile
    {
        private string url;
        private string username;
        private string password;


        public void readXmlFile()
        {
            string filename = "C:\\Users\\evelyne.franco\\source\\repos\\FrameworkProjectC\\FrameworkProjectC\\settings.xml";
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.Load(filename);
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/setFile/setting");
                foreach (XmlNode node in nodeList)
                {
                    url = node.SelectSingleNode("url").InnerText;
                    username = node.SelectSingleNode("username").InnerText;
                    password = node.SelectSingleNode("password").InnerText;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string getUrl()
        {
            return url;
        }
        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
    }
}