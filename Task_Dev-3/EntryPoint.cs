using System;

namespace Task_Dev_3
{
    /// <summary>
    /// Entry point to the program
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The main method of the program
        /// </summary>
        /// <param name="args"> The command line arguments </param>
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
                        company.FirstCriterionChooseandDisplay(money, inputProductivity);
                    if (el == "2")
                        company.SecondCriterionChooseandDisplay(money, inputProductivity);        
                    if (el == "3")
                        company.ThirdCriterionChooseandDisplay(money, inputProductivity);                    
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
