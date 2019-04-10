namespace Task6
{
    /// <summary>
    /// class,inherit from interfase
    /// </summary>
    class AmountOfCars : ICommand
    {
        HandlerCars handlercars;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="handler"> object class HandlerCars </param>
        public AmountOfCars(HandlerCars handler)
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
