namespace Task_Dev_3
{
    /// <summary>
    /// child class from Senior class, to definition variables
    /// </summary>
    class Lead : Senior
    {
        /// <summary>
        /// it's a constructor,where we redefining fields
        /// </summary>
        public Lead()
        {
            Salary += 800; 
            Productivity += 2;
        }
    }
}
