using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class AmountOfCars : ICommand
    {
        HandlerCars handlercars;

       AmountOfCars(HandlerCars handler)
        {
            this.handlercars = handler;
        }
        
        /// <summary>
        /// Implemented method. 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public void Execute()
        {
            handlercars.CountAmountOfCars();
         
        }
    }
}
