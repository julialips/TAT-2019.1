using System;

namespace Task5
{
    class SpaceShip : IFlyable
    {
        int speedFlySpaceShip = 8000;
        // double lengthway;

        public void FlyTo(int point)
        {
            Console.WriteLine("на марс");
        }

        public void WhoAmI()
        {
          
            
            Console.WriteLine("I am is SpaceShip");
        }

        public void  GetFlyTime()
        {
            FlyTime fl = new FlyTime();
            fl.lenghtAndTime(8000/*,lengthway*/);
            
        }
       /* {
            Point startpoint;
            startpoint.x = 0;
            startpoint.y = 0;
            startpoint.z = 0;

            Point finishpoint;
            finishpoint.x = 100;
            finishpoint.y = 200;
            finishpoint.z = 800;

            lengthway = Math.Sqrt(Math.Pow((finishpoint.x - startpoint.x), 2) + Math.Pow((finishpoint.y - startpoint.y), 2) + Math.Pow((finishpoint.z - startpoint.z), 2));
            Console.WriteLine($"the lengthway = { lengthway}");
            double time = lengthway / speedFlySpaceShip;
            Console.WriteLine($"time in flying is {time}");
        }*/

        int IFlyable.FlyTo(int point)
        {
            throw new NotImplementedException();
        }
    }
}
