using System;
using System.Collections.Generic;
using System.Xml;
// InnerXml возвращает всю внутреннюю разметку xml узла
namespace Task6
{
    public class HandlerCars
    {
        XmlDocument xDoc;
        XmlNode xnode;

       public  HandlerCars(/*string filename*/)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("Cars.xml");//(filename);
            }
            catch(System.IO.FileNotFoundException)
            {
                Console.WriteLine( " XML file is not found.");

            }
        }


        public int CountBrandsOfCars()
        {
            int brand = 0;
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
                        // brand += Int32.Parse(childnode.InnerText);
                    }
                }
            }
            Console.WriteLine("Amount all brands is " + differentBrands.Count);
            return differentBrands.Count;


        }


        public int CountAmountOfCars()
        {
            int brand = 0;
            XmlElement xRoot = xDoc.DocumentElement; //xDoc.DocumentElement-корневой элемент.Далее происходит разбор узлов
                                                     //  List<string> brand = new List<string>();

            foreach (XmlNode xnode in xRoot)//пробегаемся по всем дочерним узлам корневого элемента
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // получаем атрибут brand
                    // if (xnode.Attributes.Count > 0)
                    if (childnode.Name == "brand")
                    {
                        //  XmlNode attribute = xnode.Attributes.GetNamedItem("brand");//получить имя дочернего атрибута
                        // brand.Add(childnode.InnerText);                                                        // if (attribute != null)
                        brand += Int32.Parse(childnode.InnerText);                                              // Console.WriteLine(attribute.Value);
                    }
                }
            }
            Console.WriteLine("Amount all cars is " + brand);
            return brand;
            //return brand.Count;
        }

        public double CountAveragePriceOfCars()
        {
            //  List<int> price = new List<int>();
            //  List<int> number = new List<int>();
            double prise = 0;
            int numberCars = 0;
            double averagePrise = 0;
            int averageNumber = 0;
            XmlElement xRoot = xDoc.DocumentElement; //xDoc.DocumentElement-корневой элемент.Далее происходит разбор узлов
            double totalPrise = 0;

            foreach (XmlNode xnode in xRoot)//пробегаемся по всем дочерним узлам корневого элемента
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // получаем атрибут brand
                    // if (xnode.Attributes.Count > 0)
                    if (childnode.Name == "price")
                    {
                        prise = Double.Parse(childnode.InnerText);
                        averagePrise += (Double.Parse(childnode.InnerText));
                        // Console.WriteLine("price: {0}", childnode.InnerText);
                    }

                    if (childnode.Name == "number")
                    {
                        numberCars = (Int32.Parse(childnode.InnerText));
                        //  Console.WriteLine("number: {0}", childnode.InnerText);
                        averageNumber += (Int32.Parse(childnode.InnerText));
                    }

                }
                totalPrise += averagePrise / averageNumber;

            }
            Console.WriteLine("Average price of cars is " + totalPrise);
            return totalPrise;
        }

        public double CountAveragePriceEveryBrand(string typebrand)
        {
            XmlElement xRoot = xDoc.DocumentElement;
            double price = 0;
            int numberOfCar = 0;
            int totalNumber = 0;
            double totalPrise = 0;
            foreach (XmlNode xnode in xRoot)//пробегаемся по всем дочерним узлам корневого элемента
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {

                    if (childnode.Name == "brand" && childnode.InnerText == typebrand)
                    {
                        foreach (XmlNode child in xnode.ChildNodes)
                        {
                            if (child.Name == "price")
                            {
                                price = Double.Parse(child.InnerText);
                            }
                            if (child.Name == "number")
                            {
                                numberOfCar = Int32.Parse(child.InnerText);
                                totalNumber += Int32.Parse(child.InnerText);
                            }
                        }
                        totalPrise += price * numberOfCar;
                    }
                    else
                    {
                        Console.WriteLine(" There is no brand " + typebrand + "in stock! ");
                            }
                }
            }
            Console.WriteLine(" Average price" + typebrand + " = " + totalPrise);
            return totalPrise / totalNumber;
        }

        /*
        public void Method2()
        {
            List<string> model = new List<string>();
            List<int> number = new List<int>();
            List<int> price = new List<int>();
            // обходим все дочерние узлы элемента user
            foreach (XmlNode childnode in xnode.ChildNodes)//вложенные элементы атрибутов
            {
                // если узел - model
                if (childnode.Name == "model")
                {
                    model.Add(childnode.Name);

                    Console.WriteLine("model: {0}", childnode.InnerText);
                }
                // если узел number
                if (childnode.Name == "number")
                {
                    number.Add(Int32.Parse(childnode.Name));
                    Console.WriteLine("number: {0}", childnode.InnerText);
                }
                if (childnode.Name == "price")
                {
                    number.Add(Int32.Parse(childnode.Name));
                    Console.WriteLine("price: {0}", childnode.InnerText);
                }

                Console.WriteLine();


            }
        }
        */
    }
}