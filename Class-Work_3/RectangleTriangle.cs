using System;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// class of  rectangle triangle inherit from base class Triangle
    /// </summary>
    class RectangleTriangle : Triangle
    {
        /// <summary>
        /// Constructor of our class
        /// </summary>
        /// <param name="p1"> point first </param>
        /// <param name="p2"> point second </param>
        /// <param name="p3"> point third </param>
        public RectangleTriangle(Point p1, Point p2, Point p3) : base(p1, p2, p3)
        {
            if (p1.X == p2.X && p2.Y == p3.Y)
            {
                Console.WriteLine("It is NOT a Rectangle triangle");
            }
        }

        /// <summary>
        /// override implementation method GetSquare()
        /// </summary>
        /// <returns> double number of square </returns>
        public override double GetSquare()
        {
            double p = 1 / 2 * (side31 + side23 + side12);
            return Math.Sqrt(p * (p - side12) * (p - side23) * (p - side31));
        }
    }
}

