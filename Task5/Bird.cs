using System;

namespace Task5
{
    /// <summary>
    /// class, which have methods inherited and realized from interface
    /// </summary>
    class Bird : IFlyable
    {
        int speedFlyBird;
        double lengthway;
        Point point;
        Random random = new Random();

        /// <summary>
        /// constructor of our class, that initialize start point 
        /// </summary>
        public Bird()
        {
            point.SetPoint(0, 0, 0);
        }

        /// <summary>
        /// method for calculating distance between start and finish points
        /// </summary>
        /// <param name="finishpoint"> end point </param>
        public void FlyTo(Point finishpoint)
        {
            LengthWay calculatelength = new LengthWay();
            point.SetPoint(finishpoint.X, finishpoint.Y, finishpoint.Z);
            calculatelength.CalculateLength(point, finishpoint);
        }

        /// <summary>
        /// method witch return the name of object
        /// </summary>
        /// <returns> object's name </returns>
        public string WhoAmI()
        {
           return "I am a Bird";
        }

        /// <summary>
        /// method to determine the time of fly
        /// </summary>
        /// <returns> time</returns>
        public double GetFlyTime()
        {
            speedFlyBird = random.Next(1,20) ;
            if(speedFlyBird == 0)
            {
                point.SetPoint(0, 0, 0);
                return 0;
            }
            double time = lengthway / speedFlyBird;
            return time;
        }
    }
}
