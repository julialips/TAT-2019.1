using System;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// class BuilderIqualTriangle,witch is inherit fron base class Builder
    /// </summary>
    class BuilderIqualTriangle : Builder
    {
        /// <summary>
        /// Constructor of our class
        /// </summary>
        /// <param name="builder"></param>
        public BuilderIqualTriangle(Builder builder)
        {
            Successor = builder;
        }

        /// <summary>
        /// Override method ,whitch tests the ability to create such triangle
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <returns></returns>
        public override Triangle Build(Point p1, Point p2, Point p3)
        {
            double ab = Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
            double bc = Math.Sqrt(Math.Pow((p3.X - p2.X), 2) + Math.Pow((p3.Y - p2.Y), 2));
            double ca = Math.Sqrt(Math.Pow((p1.X - p3.X), 2) + Math.Pow((p1.Y - p3.Y), 2));

            if (ab - bc > float.Epsilon && bc - ca > float.Epsilon && ca - ab > float.Epsilon)
            {
                return new EquilateralTriangle(p1, p2, p3);
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
