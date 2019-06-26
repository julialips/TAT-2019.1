namespace Task_Dev_3
{
    /// <summary>
    /// child class from Middle class, to definition variables
    /// </summary>
    class Senior : Middle
    {   
        /// <summary>
        /// it's a constructor,where we redefining fields
        /// </summary>
        public Senior()
        {
            Salary += 450; 
            Productivity += 2;
        }
    }
}
