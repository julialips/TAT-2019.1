namespace Task6
{
    /// <summary>
    /// class,inherit from interfase
    /// </summary>
    class TypesOfAllBrands : ICommand
    {
        HandlerCars handlercars;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="handler"> object </param>
       public TypesOfAllBrands(HandlerCars handler)
        {
            this.handlercars = handler;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Execute()
        {
            handlercars.CountBrandsOfCars();
        }
    }
}
