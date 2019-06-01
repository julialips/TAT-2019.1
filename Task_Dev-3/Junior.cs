namespace Task_Dev_3
{
    /// <summary>
    /// child class from Worker class, to definition variables
    /// </summary>
    class Junior : Worker
    {
        /// <summary>
        /// it's a constructor,where we redefining fields
        /// </summary>
        public Junior()
        {
            Salary *= 1; 
            Productivity *= 1; 
        }
    }
}
