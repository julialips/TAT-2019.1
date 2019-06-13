using System;
using System.Xml;

namespace Task6
{
    /// <summary>
    /// class,contains 1 method
    /// </summary>
   class ReaderFromXML
    {
        /// <summary>
        /// method for reading text from xml file and print to console
        /// </summary>
        public void Read(string file,string file2)
        {
            XmlDocument xDoc = new XmlDocument();
            XmlDocument xDoc2 = new XmlDocument();
            xDoc.Load(@"C:\Users\user\source\repos\TAT-2019.1\Task6\" + file);
            xDoc2.Load(@"C:\Users\user\source\repos\TAT-2019.1\Task6\" + file2);
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement xRoot2 = xDoc2.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "brand")
                    {
                        Console.WriteLine("Brand: {0}", childnode.InnerText);
                    }

                    if (childnode.Name == "model")
                    {
                        Console.WriteLine("Model: {0}", childnode.InnerText);
                    }

                    if (childnode.Name == "number")
                    {
                        Console.WriteLine("Number: {0}", childnode.InnerText);
                    }

                    if (childnode.Name == "price")
                    {
                        Console.WriteLine("Price: {0}", childnode.InnerText);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------");
            foreach (XmlNode xnode in xRoot2)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "brand")
                    {
                        Console.WriteLine("Brand: {0}", childnode.InnerText);
                    }

                    if (childnode.Name == "model")
                    {
                        Console.WriteLine("Model: {0}", childnode.InnerText);
                    }

                    if (childnode.Name == "number")
                    {
                        Console.WriteLine("Number: {0}", childnode.InnerText);
                    }

                    if (childnode.Name == "price")
                    {
                        Console.WriteLine("Price: {0}", childnode.InnerText);
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
