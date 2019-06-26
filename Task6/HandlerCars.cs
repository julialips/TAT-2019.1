using System;
using System.Collections.Generic;
using System.Xml;

namespace Task6
{
    /// <summary>
    /// class,contains methods  and reading text from xml file
    /// </summary>
    public class HandlerCars
    {
        XmlDocument xDoc = new XmlDocument();

        /// <summary>
        /// constructor our class,which read from xml
        /// </summary>
        public HandlerCars(string filename)
        {
            try
            {
                xDoc.Load(filename);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine(" XML file is not found.");
            }
        }

        /// <summary>
        /// method for counting amount of brands
        /// </summary>
        public void CountBrandsOfCars()
        {
            int number = 0;
            int averageNumber = 0;
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "number")
                    {
                        number = Int32.Parse(childnode.InnerText);
                        averageNumber += (Int32.Parse(childnode.InnerText));
                    }
                }
            }
            Console.WriteLine("Amount all cars : " + averageNumber);
        }

        /// <summary>
        /// method for counting amount of cars
        /// </summary>
        public void CountAmountOfCars()
        {
            List<string> differentBrands = new List<string>();
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "brand")
                    {
                        if (!differentBrands.Contains(childnode.InnerText))
                        {
                            differentBrands.Add(childnode.InnerText);
                            Console.WriteLine(childnode.InnerText);
                        }
                    }

                }
            }
            Console.WriteLine("Brands : " + differentBrands.Count);
        }

        /// <summary>
        /// method counting average price of cars
        /// </summary>
        /// <returns></returns>
        public double CountAveragePriceOfCars()
        {
            int countModels = 0;
            double prise = 0;
            double totalPrise = 0;
            double averagePrise = 0;
            XmlElement xRoot = xDoc.DocumentElement;
        
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "price")
                    {
                        prise = Double.Parse(childnode.InnerText);
                        averagePrise += (Double.Parse(childnode.InnerText));
                        countModels++;
                    }
                }
                totalPrise = averagePrise / countModels;
            }
            Console.WriteLine("Average price of cars is " + totalPrise);
            return totalPrise;
        }

        /// <summary>
        /// method counting avegare price of car by type
        /// </summary>
        /// <param name="typebrand">type of car </param>
        public void CountAveragePriceEveryBrand(string typebrand)
        {
            XmlElement xRoot = xDoc.DocumentElement;
            double price = 0;
            int count = 0;

            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "brand" && childnode.InnerText == typebrand)
                    {
                        foreach (XmlNode child in xnode.ChildNodes)
                        {
                            if (child.Name == "price")
                            {
                                price += Double.Parse(child.InnerText);
                                count++;
                            }                        
                        }
                    }
                }
            }
            if (count > 0)
            {
                Console.WriteLine("Average price " + typebrand + " = " + price / count);
            }
            else
            {
                Console.WriteLine("Salon have not car this brand " + typebrand);
            }
        }
    }
}