using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Task6
{
    /// <summary>
    /// Class for parsing xml file
    /// </summary>
    class CarsDataBase
    {
        private static CarsDataBase instance;
        private XDocument XDoc { get; set; }
        
        /// <summary>
        /// constructor our class,which allocate memory for xml document
        /// </summary>
        private CarsDataBase()
        {
            this.XDoc = new XDocument();
        }

        /// <summary>
        /// Singleton pattern
        /// Creates object if it does not exist
        /// </summary>
        /// <returns>CarsDataBase object</returns>
        public static CarsDataBase GetInstance()
        {
            if (instance == null)
            {
                instance = new CarsDataBase();
            }
            return instance;
        }

        /// <summary>
        /// Method, which Loads xml file and gets cars
        /// </summary>
        /// <param name="fileName">name of xml file </param>
        /// <returns> cars collection </returns>
        public IEnumerable<Car> GetCars(string fileName)
        {
            XDoc = XDocument.Load(@"C:\Users\user\source\repos\TAT-2019.1\Task6\{ fileName}");

            IEnumerable<Car> cars = XDoc.Element("cars").Elements("car").Select(xe => new Car
           (
           xe.Element("brand").Value,xe.Element("model").Value,
            int.TryParse(xe.Element("number").Value, out int number) ? number : throw new Exception("Incorrect count value"),
            int.TryParse(xe.Element("price").Value, out int price) ? price : throw new Exception("Incorrect price value"))
            );

            return cars;
        }
    }
}
