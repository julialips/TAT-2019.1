using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class AveragePriceOfCar : ICommand
    {
        HandlerCars handlercars;

        AveragePriceOfCar(HandlerCars handler)
        {
            this.handlercars = handler;
        }

        public void Execute()
        {
            handlercars.CountAveragePriceOfCars();
           
        }
    }
}
