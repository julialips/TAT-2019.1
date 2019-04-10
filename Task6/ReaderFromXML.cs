using System;
using System.Xml;
using System.Collections.Generic;

namespace Task6
{
    /// <summary>
    /// class,contains 1 method
    /// </summary>
   class ReaderFromXML
    {
        XmlDocument xDoc;
        XmlNode xnode;

        /// <summary>
        /// method for reading text from xml file and print to console
        /// </summary>
        public void Read(string file)
        {
            XmlDocument xDoc = new XmlDocument();
            //xDoc.Load("Cars.xml");
            xDoc.Load(@"C:\Users\user\source\repos\TAT-2019.1\Task6\" + file);
            XmlElement xRoot = xDoc.DocumentElement;            

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
         Console.Read();
        }
    }
}
