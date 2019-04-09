using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class AveragePriceOfCarEveryBrand : ICommand
    {
        HandlerCars handlercars;
        AveragePriceOfCarEveryBrand(HandlerCars handler)
        {
            this.handlercars = handler;
        }

        public void Execute()
        {
            Console.WriteLine("Enter type :");
            handlercars.CountAveragePriceEveryBrand(Console.ReadLine());
           
        }
    }
}
