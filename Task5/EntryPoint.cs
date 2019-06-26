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
                Console.WriteLine(bird.WhoAmI());
                bird.FlyTo(point);
                Console.WriteLine(bird.GetFlyTime());
                
                Plane plane = new Plane();
                Console.WriteLine(plane.WhoAmI());
                plane.FlyTo(point);
                Console.WriteLine(plane.GetFlyTime());

                SpaceShip spaceShip = new SpaceShip();
                Console.WriteLine(spaceShip.WhoAmI());
                spaceShip.FlyTo(point);
                Console.WriteLine(spaceShip.GetFlyTime());
            }
            catch
            {
                Console.WriteLine("Something went wrong, try again!");
            }            
        }
    }
}
