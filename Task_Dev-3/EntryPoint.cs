using System;

namespace Task_Dev_3
{
    /// <summary>
    /// Entry point to the program.From this class, user can choose method, which will sorting workers.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The main method of the program.Here we create objects of difference classes? and starts his methods.
        /// </summary>
        /// <param name="args"> The command line arguments,1,2 or 3 </param>
        static void Main(string[] args)
        {
            try
            {
                int inputProductivity;
                int money;   
                if (args[0].Length > 1)
                {
                    throw new FormatException();
                }
                Console.WriteLine("Money to buy workers : ");
                money = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total productivity : ");
                inputProductivity = Convert.ToInt32(Console.ReadLine());
                Company company = new Company(inputProductivity);
                foreach (string el in args)
                {
                    if (el == "1")
                    {
                        company.MaximumProductivityDisplay(money, inputProductivity);
                    }
                    
                    if (el == "2")
                    {
                        company.MinimumCostDisplay(money, inputProductivity);   
                    }
                    
                    if (el == "3")
                    {
                        company.MinimumNumberHigherThanJuniorDisplay(money, inputProductivity);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("OOps, you must chose ONE criterion :(");
            }
            catch (Exception)
            {
                Console.WriteLine("OOps, something went wrong,try again:(");
            }
        }
    }
}
