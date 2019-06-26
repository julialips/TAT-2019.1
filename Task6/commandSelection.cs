using System;

namespace Task6
{
    /// <summary>
    /// class whitch start methods
    /// </summary>
    class CommandSelection
    {
        private ICommand Command { get; set; }
        private Action ExecuteCommands { get; set; }
        /// <summary>
        /// method, using switch-case for choosing needed methods
        /// </summary>
        /// <param name="name"></param>
        public CommandSelection(string name, string name2)
        {
            ReaderFromXML readerFromXML = new ReaderFromXML();
            Invoker invoker = new Invoker();
            HandlerCars handlerCars = new HandlerCars(@"C:\Users\user\source\repos\TAT-2019.1\Task6\" + name,
                                                      @"C:\Users\user\source\repos\TAT-2019.1\Task6\" + name2);

            Console.WriteLine("Select command (1-5): \n 1.Count car brands \n 2.Count all cars \n " +
                              "3.Average car price \n 4.Average price type \n 5.Clear console \n 6.Execute \n 7.Exit");
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
                        readerFromXML.Read("Cars.xml", "Trucks.xml");
                        break;
                    case "6":
                        invoker = null;
                        continue;
                    сase "7":
                        break;
                    default:
                        Console.WriteLine("Chose number only from 1 to 6");
                        break;
                }
                ExecuteCommands += invoker.StartMethod;
            }
            ExecuteCommands?.Invoke();
        }

        /// <summary>
        /// structure of car types
        /// </summary>
        public enum CarType
        {
            Passenger,
            Truck
        }
        
        /// <summary>
        /// Methosd returns type of car 
        /// </summary>
        /// <returns>Int type of car</returns>
        private int ChoosingTypeOfCar()
        {
            int typeOfCar = 0;

            for (bool entry = true; entry;)
            {
                Console.WriteLine("Choose type of car (1-2)):\n" + $" 1. {CarType.Passenger}\n" + $"2. {CarType.Truck}");

                if (!int.TryParse(Console.ReadLine(), out typeOfCar))
                {
                    Console.WriteLine("Our salon have not this type");
                    continue;
                }

                entry = false;
            }

            return --typeOfCar;
        }
    }
}

