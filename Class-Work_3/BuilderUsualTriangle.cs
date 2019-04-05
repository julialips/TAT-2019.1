﻿using System;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// class BuilderRectTriangle,witch is inherit fron base class Builder
    /// </summary>
    class BuilderUsualTriangle : Builder
    {
        /// <summary>
        /// Constructor of our class
        /// </summary>
        /// <param name="builder"></param>
        public BuilderUsualTriangle(Builder builder)
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
            double ab = Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
            double bc = Math.Sqrt(Math.Pow((p3.X - p2.X), 2) + Math.Pow((p3.Y - p2.Y), 2));
            double ca = Math.Sqrt(Math.Pow((p1.X - p3.X), 2) + Math.Pow((p1.Y - p3.Y), 2));

            if (ab + bc > ca && bc + ca > ab && ca + ab > bc)
            {
                return new UsualTriangle(p1, p2, p3);
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
