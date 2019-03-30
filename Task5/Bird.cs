using System;

namespace Task5
{
    class Bird : IFlyable
    {
        int speedFlyBird;
        Random random = new Random();

        public void FlyTo(int point)
        {
            Console.WriteLine("НА ЮГ");
            int g = point;

            // Point newPoint
        }

        public void WhoAmI()
        {
            Console.WriteLine("I am is a Bird");
        }

        public void GetFlyTime()
        {
            
            // for(int i = 0; i < 1; i++)
            // {
            speedFlyBird = random.Next(0,20) ;
            Console.WriteLine ($"Speed of bird is{speedFlyBird }");
            // }
            FlyTime flytime = new FlyTime();
            flytime.lenghtAndTime(speedFlyBird);

        }

        int IFlyable.FlyTo(int point)
        {
            throw new NotImplementedException();
        }
    }
}
