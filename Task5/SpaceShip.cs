namespace Task5
{
    /// <summary>
    /// class, which have methods inherited and realized from interface
    /// </summary>
    class SpaceShip : IFlyable
    {
        Point point;
        double speedFlySpaceShip;
        double lengthway;
       
        /// <summary>
        /// constructor of our class, that initialize start point and speed
        /// </summary>
        public SpaceShip()
        {
            point.SetPoint(0, 0, 0);
            speedFlySpaceShip = 8000; 
        }

        /// <summary>
        /// method for calculating distance between start and finish points
        /// </summary>
        /// <param name="finishpoint"> finish point of distance </param>
        public void FlyTo(Point finishpoint)
        {
           LengthWay calculatelength = new LengthWay();
           calculatelength.CalculateLength(point, finishpoint);
           point.SetPoint(finishpoint.X, finishpoint.Y, finishpoint.Z);
        }

        /// <summary>
        /// method witch return the name of object
        /// </summary>
        /// <returns> string name of object </returns>
        public string WhoAmI()
        {
          return "I am SpaceShip";
        }

        /// <summary>
        /// method to determine the time of fly
        /// </summary>
        /// <returns> time of fly </returns>
        public double  GetFlyTime()
        {  
            double time = lengthway / speedFlySpaceShip;
            
            return time;
        }
    }
}
