namespace Task5
{
    /// <summary>
    /// Struct for determine point's coordinates
    /// </summary>
    struct Point
    {
        /// <summary>
        /// method, which gets and sets the value of a coordinates
        /// </summary>
        public void SetPoint(int x, int y, int z)
        {
           X = x;
           Y = y;
           Z = z;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
}