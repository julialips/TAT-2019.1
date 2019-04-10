namespace Task6
{
    /// <summary>
    /// class,inherit from interfase
    /// </summary>
    class AveragePriceOfCar : ICommand
    {
        HandlerCars handlercars;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="handler"></param>
        public AveragePriceOfCar(HandlerCars handler)
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
            handlercars.CountAveragePriceOfCars(); 
        }
    }
}
