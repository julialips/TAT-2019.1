using System;
namespace Task5
{
    class Plane : IFlyable
    {
        int lengthWay;
        int speedFlyPlane;
        public void FlyTo(int point)
        {
            Console.WriteLine("НА марс");
            int g = point;

            // Point newPoint
        }

        public void WhoAmI()
        {
            Console.WriteLine("я космич");
        }

        public void GetFlyTime()
        { //- Самолет развивает скорость +10 км / час каждые 10 км полета, начиная с 200 км / час;
          // for (int i=10; i<lengthWay; i++)
          // {
            if (speedFlyPlane == 200)
            {
               // if (lengthWay =+  10)
                //{
                    speedFlyPlane += 10 / (lengthWay / 20);
                //}
            }
           // }

            Console.WriteLine("времечко");
        }

        int IFlyable.FlyTo(int point)
        {
            throw new NotImplementedException();
        }
    }
}
