using System;

namespace Task6
{
    /// <summary>
    /// class whitch start methods
    /// </summary>
    class CommandSelection
    {
        /// <summary>
        /// method, using switch-case for choosing needed methods
        /// </summary>
        /// <param name="name"></param>
        public CommandSelection(string name)
        {
            ReaderFromXML readerFromXML = new ReaderFromXML();
            Invoker invoker = new Invoker();
            HandlerCars handlerCars = new HandlerCars(@"C:\Users\user\source\repos\TAT-2019.1\Task6\" + name);

            Console.WriteLine("Select command (1-5): \n 1.Count car brands \n 2.Count all cars \n " +
                              "3.Average car price \n 4.Average price type \n 5.Clear console \n 6.Exit");
            string selection = Console.ReadLine();

            while ((selection = Console.ReadLine().ToLower()) != "6")
            {
                switch (selection)
                {
                    case "1":
                          invoker.SetCommand(new AmountOfCars(handlerCars));
                          invoker.StartMethod();                      
                        break;
                    case "2":
                        invoker.SetCommand(new TypesOfAllBrands(handlerCars));
                        invoker.StartMethod();
                        break;
                    case "3":
                        invoker.SetCommand(new AveragePriceOfCar(handlerCars));
                        invoker.StartMethod();
                        break;
                    case "4":
                        invoker.SetCommand(new AveragePriceOfCarEveryBrand(handlerCars));
                        invoker.StartMethod();
                        break;
                    case "5":
                        Console.Clear();
                        readerFromXML.Read("Cars.xml");
                        break;
                    case "6":
                        break;
                    default:
                        Console.WriteLine("Chose number only from 1 to 6");
                        break;
                }
            }
        }
    }
}