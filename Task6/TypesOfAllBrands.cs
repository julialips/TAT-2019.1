using System;

namespace Task6
{
    class TypesOfAllBrands : ICommand
    {
        HandlerCars handlercars;

        TypesOfAllBrands(HandlerCars handler)
        {
            this.handlercars = handler;
        }

        public void Execute()
        {
            handlercars.CountBrandsOfCars();
            
        }
    }
}
