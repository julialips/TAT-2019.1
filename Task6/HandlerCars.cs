using System;
using System.Collections.Generic;
using System.Xml;

namespace Task6
{
    /// <summary>
    /// class,contains methods  and reading text from xml file
    /// </summary>
    class HandlerCars
    {
        public IEnumerable<Car> Cars { get; private set; }
        XmlDocument xDoc = new XmlDocument();
        XmlDocument xDoc2 = new XmlDocument();

        
         public HandlerCars(IEnumerable<Car> cars)
         {
             Cars = cars;    
         }
         
        /// <summary>
        /// constructor our class,which read from xml
        /// </summary>
        public HandlerCars(string filename, string filename2 )
        {
            try
            {
                xDoc.Load(filename);
                xDoc2.Load(filename2);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine(" XML file is not found.");
            }
        }
      
        /// <summary>
        /// method for counting amount of brands
        /// </summary>
        public int   CountBrandsOfCars()
        {
            return Cars.GroupBy(car => car.Brand).Count();
        }

        /// <summary>
        /// method for counting amount of cars
        /// </summary>
        public int CountAmountOfCars()
        {
            return Cars.Select(car => car.Number).Sum();

        }

        /// <summary>
        /// method counting average price of cars
        /// </summary>
        /// <returns></returns>
        public double CountAveragePriceOfCars()
        {

            return Cars.Select(car => car.Price).Average();
        }

        /// <summary>
        /// method counting avegare price of car by type
        /// </summary>
        /// <param name="typebrand">type of car </param>
        public double CountAveragePriceEveryBrand(string typebrand)
        {
            if (Cars.Select(car => car.Brand).Contains(typebrand.ToLower()))
            {
                return Cars.Where(car => car.Brand == typebrand.ToLower()).Select(car => car.Price).Average();
            }
            else
            {
                throw new Exception("Salon have not car this brand ");
            }
        }
    }
}