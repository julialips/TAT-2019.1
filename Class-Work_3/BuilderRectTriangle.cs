using System;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// class BuilderRectTriangle,witch is inherit fron base class Builder
    /// </summary>
    class BuilderRectTriangle : Builder
    {
        /// <summary>
        /// Constructor of our class
        /// </summary>
        /// <param name="builder"></param>
        public BuilderRectTriangle(Builder builder)
        {
            Successor = builder;
        }

        /// <summary>
        /// Override method ,whitch tests the ability to create such triangle
        /// </summary>
        /// <param name="p1"> point 1 </param>
        /// <param name="p2"> point 2 </param>
        /// <param name="p3"> point 3 </param>
        /// <returns>new object of triangle or builded triangle </returns>
        public override Triangle Build(Point p1, Point p2, Point p3)
        {
            if (p1.X == p2.X && p2.Y == p3.Y)
            {
                return new RectangleTriangle(p1, p2, p3);
            }

            else if (Successor != null)
            {
                return Successor.Build(p1, p2, p3);
            }

            else
            {
                throw new FormatException("No one of successors can't do this!");
            }
        }
    }
}
