using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class CommandSelection
    {
        AmountOfCars amountOfCars;

        public CommandSelection(string name)
        {

            ICommand command;

            Invoker invoker = new Invoker();
            HandlerCars handlerCars = new HandlerCars();//("@Cars.xml"/*@"C:\Users\user\sourse\repos\TAT-2019.1\Task6\Cars.xml" + name*/);
            Console.WriteLine("Select command (1-5): \n 1.Count car types \n 2.Count all types \n 3.Average car price \n 4.Average price type \n 5.Exit");

            string selection = Console.ReadLine();
            while ((selection = Console.ReadLine().ToLower()) != "5")
            {
                switch (selection)
                {
                    case "1":
                      //  new AmountOfCars();
                        amountOfCars.Execute();

                        //   invoker.SetCommand(amountOfCars);
                        //  invoker.StartMethod();
                        //  new CountBrandsOfCars();
                        Console.WriteLine("Вы нажали 1");
                        break;
                    case "2":
                        Console.WriteLine("Вы нажали 2");
                        break;
                    case "3":
                        Console.WriteLine("Вы нажали 3");
                        break;
                    case "4":
                        Console.WriteLine("Вы нажали 4");
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Chose number only from 1 to 5");
                        break;
                }
              
            }

        }
    }
}