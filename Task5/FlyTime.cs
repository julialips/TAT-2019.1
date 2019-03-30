using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
     class FlyTime
    {
        public double lenghtAndTime(int speedFlySpaceShip/*, double lengthway*/)
        {
            Point startpoint;
            startpoint.x = 0;
            startpoint.y = 0;
            startpoint.z = 0;

            Point finishpoint;
            finishpoint.x = 100;
            finishpoint.y = 200;
            finishpoint.z = 800;

           double lengthway = Math.Sqrt(Math.Pow((finishpoint.x - startpoint.x), 2) + Math.Pow((finishpoint.y - startpoint.y), 2) + Math.Pow((finishpoint.z - startpoint.z), 2));
            Console.WriteLine($"the lengthway = { lengthway}");
            double time = lengthway / speedFlySpaceShip;
            Console.WriteLine($"time in flying is {time}");
            return time;
        }
    }
}
