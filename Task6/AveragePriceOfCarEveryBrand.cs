using System;

namespace Task6
{
    /// <summary>
    /// class,inherit from interfase
    /// </summary>
    class AveragePriceOfCarEveryBrand : ICommand
    {
        HandlerCars handlercars;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="handler"></param>
        public AveragePriceOfCarEveryBrand(HandlerCars handler)
        {
            this.handlercars = handler;
        }

        /// <summary>
        /// Implemented method, which start other method to calculate 
        /// </summary>
        /// <param name="type"> it is a car brand </param>
        /// <returns> void </returns>
        public void Execute()
        {
            try
            {
                Console.WriteLine("Enter type :");
                handlercars.CountAveragePriceEveryBrand(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Type is not found,write again");
            }
        }
    }
}
