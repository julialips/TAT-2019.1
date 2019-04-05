using System;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// Main class of program
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// main method, which runs other methods, and creating objects
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                Point p1 = new Point(1, 1);
                Point p2 = new Point(1, 3);
                Point p3 = new Point(4, 3);
                //RectangleTriangle receiver = new RectangleTriangle(false, true, true);
                Builder builder = new BuilderRectTriangle(new BuilderIqualTriangle(new BuilderUsualTriangle(null)));
                Triangle triangle = builder.Build(p1, p2, p3);
                Console.WriteLine(triangle.GetSquare());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }
        }
    }
}
