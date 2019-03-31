using System;

namespace Task5
{
    /// <summary>
    /// Main class of program
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// main method, which runs other methods, and creating objects
        /// </summary>
        static void Main()
        {
            try
            {
                Point point = new Point();
                point.SetPoint(100, 200, 800);
                Bird bird = new Bird();
                bird.WhoAmI();
                bird.FlyTo(point);
                bird.GetFlyTime();

                Plane plane = new Plane();
                plane.WhoAmI();
                plane.FlyTo(point);
                plane.GetFlyTime();

                SpaceShip spaceShip = new SpaceShip();
                spaceShip.WhoAmI();
                spaceShip.FlyTo(point);
                spaceShip.GetFlyTime();
            }
            catch
            {
                Console.WriteLine("Something went wrong, try again!");
            }            
        }
    }
}
