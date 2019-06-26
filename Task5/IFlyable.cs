namespace Task5
{
    /// <summary>
    /// Interface, that have 3 methods which are overrides in classes
    /// </summary>
    interface IFlyable
    {
        /// <summary>
        /// method to determine the distance
        /// </summary>
        /// <param name="point"> finish point </param>
        void FlyTo(Point point);

        /// <summary>
        /// method for determine the object
        /// </summary>
        /// <returns> string name </returns>
        string WhoAmI();

        /// <summary>
        /// method to determine the time of fly
        /// </summary>
        /// <returns> time </returns>
        double GetFlyTime();
    }
}
