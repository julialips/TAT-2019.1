using System;

namespace Task5
{
    /// <summary>
    /// class, which have 1 method for calculate the lengthway
    /// </summary>
    class LengthWay
    {
        /// <summary>
        /// method calculating the lengthway of fly by formula
        /// </summary>
        /// <param name="point"> start point </param>
        /// <param name="finishpoint"> end point of fly </param>
        /// <returns> returns the length of distance </returns>
        public double CalculateLength(Point point, Point finishpoint)
        {
           double lengthway = Math.Sqrt(Math.Pow((finishpoint.X - point.X), 2) + 
                                        Math.Pow((finishpoint.Y - point.Y), 2) +
                                        Math.Pow((finishpoint.Z - point.Z), 2));
           return lengthway;
        }
    }
}
