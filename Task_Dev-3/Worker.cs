namespace Task_Dev_3
{
    /// <summary>
    /// base abstruct class for inheritance
    /// </summary>
    abstract class Worker
    {
        public int Salary { get; set; }
        public int Productivity { get; set; }

        public Worker()
        {
            Salary = 250;
            Productivity = 3;
        }
    }
}
