namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// Structure for determine coordinates of the point
    /// </summary>
    public struct Point
    {
        public float X;
        public float Y;

        /// <summary>
        /// Constructor of structure
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}

