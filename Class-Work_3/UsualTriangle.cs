using System;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// class of  Usual triangle inherit from base class Triangle
    /// </summary>
    class UsualTriangle : Triangle
    {
        /// <summary>
        /// Constructor of our class
        /// </summary>
        /// <param name="p1"> point first </param>
        /// <param name="p2"> point second </param>
        /// <param name="p3"> point third </param>
        public UsualTriangle(Point p1, Point p2, Point p3) : base(p1, p2, p3)
        {
            if (side12 + side23 > side31 && side23 + side31 > side12 && side31 + side12 > side23)
            {
                Console.WriteLine("It's NOT a Usual Triangle");
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
