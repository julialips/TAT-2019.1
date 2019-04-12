using System;
using System.Collections.Generic;

namespace Task6
{
    /// <summary>
    /// Main class of program
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Entry poin of program.Here we get names of 2 xml files and start methods.
        /// </summary>
        /// <param name="args"> name of xml file </param>
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    throw new Exception("Arguments must have 2 file");
                }
                ReaderFromXML readerFromXML = new ReaderFromXML();
                readerFromXML.Read(args[0],args[1]);

                CarsDataBase carsDataBase;
                carsDataBase = CarsDataBase.GetInstance(); 
                
                List<HandlerCars> cars = new List<HandlerCars>()
                {
                    new HandlerCars(CarsDataBase.GetCars(args[(int)selection.CarType.Passenger])),
                    new HandlerCars(CarsDataBase.GetCars(args[(int)CarType.Truck]))
                };

                CommandSelection commandSelection = new CommandSelection(args[0],args[1]);
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Error! You didn't put name XML-file");
            }
        }
    }
}
