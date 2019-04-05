using System;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// abstruct  base class,contains method GetSquare() and variables
    /// </summary>
    abstract class Triangle
    {
        /// <summary>
        /// points for building a triangle
        /// </summary>
        public Point p1;
        public Point p2;
        public Point p3;

        /// <summary>
        /// sides of triangles
        /// </summary>
        public double side12;
        public double side23;
        public double side31;

        /// <summary>
        /// Base constructor for our class
        /// </summary>
        /// <param name="p1"> point 1 </param>
        /// <param name="p2"> point 2 </param>
        /// <param name="p3"> point 3 </param>
        public Triangle(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;

            side12 = Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
            side23 = Math.Sqrt((p3.X - p2.X) * (p3.X - p2.X) + (p3.Y - p2.Y) * (p3.Y - p2.Y));
            side31 = Math.Sqrt((p3.X - p1.X) * (p3.X - p1.X) + (p3.Y - p1.Y) * (p3.Y - p1.Y));

            if ((side12 > side23 + side31) || (side23 > side31 + side12) || (side31 > side12 + side23))
            {
                throw new Exception("It is not a triangle!");
            }
        }

        /// <summary>
        /// abstruct class for calculating the area of triangles
        /// </summary>
        /// <returns> sguare </returns>
        abstract public double GetSquare();

        /// <summary>
        /// method whitch calculate the sides of tringles
        /// </summary>
        /// <returns></returns>
        public double GetSide()
        {
            return Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }
    }
}
