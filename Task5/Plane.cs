namespace Task5
{
    /// <summary>
    /// class, which have methods inherited and realized from interface
    /// </summary>
    class Plane : IFlyable
    {
        int lengthway;
        int speedFlyPlane;
        double time;
        Point point;

        /// <summary>
        /// constructor of our class, that initialize start point and speed
        /// </summary>
        public Plane()
        {
            point.SetPoint(0, 0, 0);
            speedFlyPlane = 200;
        }

        /// <summary>
        /// method for calculating distance between start and finish points
        /// </summary>
        /// <param name="finishpoint"> new point </param>
        public void FlyTo(Point finishpoint)
        {
            LengthWay calculatelength = new LengthWay();
            calculatelength.CalculateLength(point, finishpoint);
            point.SetPoint(finishpoint.X, finishpoint.Y, finishpoint.Z);
        }

        /// <summary>
        /// method which return the name of object
        /// </summary>
        /// <returns> object's name </returns>
        public string WhoAmI()
        {
            return "I am a Plane";
        }

        /// <summary>
        /// method to determine the time of fly
        /// </summary>
        /// <returns> time in fly </returns>
        public double GetFlyTime()
        {
           while(lengthway <= 10)
            {       
                lengthway -= 10;
                speedFlyPlane += 10;

            }
            double time = lengthway / speedFlyPlane;
            return time;
        }
    }
}
