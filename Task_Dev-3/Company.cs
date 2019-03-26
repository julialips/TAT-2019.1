using System;

namespace Task_Dev_3
{
    /// <summary>
    /// Class , containing 3 methods ,for choosing workers
    /// </summary>
    class Company
    {
        int leadAmount;
        int middleAmount;
        int seniorAmount;
        int juniorAmount;
        int juncoast;
        int midcoast;
        int sencoast;
        int leadcoast;
        private Junior junior;
        private Middle middle;
        private Senior senior;
        private Lead lead;
        private int InputProductivity { get; set; }
       
        public Company(int inputProductivity)
        {
            InputProductivity = inputProductivity;
            junior = new Junior();
            middle = new Middle();
            senior = new Senior();
            lead = new Lead();
        }
        /// <summary>
        /// This criterion choose workers have maximum productivity within the sum
        /// </summary>
        /// <param name="money"> input parametr from console </param>
        /// <param name="inputProductivity"> parametr from console </param>
        public void MaximumProductivityDisplay(int money, int inputProductivity)
        {   
            Console.WriteLine("You choose the first criterion");
            
            leadAmount = money / lead.Salary;
            int leadLeftBalance = money % lead.Salary;
            
            middleAmount = leadLeftBalance / middle.Salary;
            int middleLeftBalance = leadLeftBalance % middle.Salary;
            
            seniorAmount = middleLeftBalance / senior.Salary;
            int seniorLeftBalance = middleLeftBalance % senior.Salary;
            
            juniorAmount = seniorLeftBalance / junior.Salary;
            int juniorLeftBalance = seniorLeftBalance % junior.Salary;

            Console.WriteLine("Leads:");
            Console.WriteLine(leadAmount);
            Console.WriteLine("Middles:");
            Console.WriteLine(middleAmount);
            Console.WriteLine("Seniors:");
            Console.WriteLine(seniorAmount);
            Console.WriteLine("Juniors:");
            Console.WriteLine(juniorAmount);
        }
        /// <summary>
        /// This criterion choose workers havin  minimal cost with fixed productivity
        /// </summary>
        /// <param name="money"> input parametr from console </param>
        /// <param name="inputProductivity"> parametr from console </param>
        public void MinimumCostDisplay(int money, int inputProductivity)
        {
            Console.WriteLine("You choose the second criterion");
            if (inputProductivity <= 0)
                throw new Exception();
            
            juniorAmount = inputProductivity / junior.Productivity;
            middleAmount = inputProductivity / middle.Productivity;
            seniorAmount = inputProductivity / senior.Productivity;
            leadAmount = inputProductivity / lead.Productivity;
           
            juncoast = juniorAmount * junior.Salary;
            midcoast = middleAmount * middle.Salary;
            sencoast = seniorAmount * senior.Salary;
            leadcoast = leadAmount * lead.Salary;
            
            if (juniorAmount > middleAmount && juniorAmount > seniorAmount && juniorAmount > leadAmount)
            {
                if (money >= juncoast)
                {
                    Console.WriteLine("Juniors:");
                    Console.WriteLine(juniorAmount);
                }
                else { Console.WriteLine("NOT enough money,for required productivity!"); }
            }
            
            if (middleAmount > juniorAmount && middleAmount > seniorAmount && middleAmount > leadAmount)
            {
                if (money >= middleAmount)
                {
                    Console.WriteLine("Middles:");
                    Console.WriteLine(middleAmount);
                }
                else
                { Console.WriteLine("NOT enough money,for required productivity!"); }
            }
            
            if (seniorAmount > juniorAmount && seniorAmount > middleAmount && seniorAmount > leadAmount)
            {
                if (money >= seniorAmount)
                {
                    Console.WriteLine("Seniors:");
                    Console.WriteLine(seniorAmount);
                }
                else
                { Console.WriteLine("NOT enough money,for required productivity!"); }
            }
            
            if (leadAmount > juniorAmount && leadAmount > middleAmount && leadAmount > seniorAmount)
            {
                if (money >= leadAmount)
                {
                    Console.WriteLine("Leads:");
                    Console.WriteLine(leadAmount);
                }
                else
                { Console.WriteLine("NOT enough money,for required productivity!"); }
            }
        }
        /// <summary>
        /// Future method for choosing the minimum number of staff qualifications is higher.
        /// </summary>
        /// <param name="money"></param>
        /// <param name="inputProductivity"></param>
        public void MinimumNumberHigherThanJuniorDisplay(int money, int inputProductivity)
        {
            Console.WriteLine("You choose the third criterion , try to choose 1 or 2 , they are better:)");   
        }
    }
}
