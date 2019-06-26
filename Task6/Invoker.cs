namespace Task6
{
    /// <summary>
    /// class contains 2 methods, working with command.User choose command from switch.
    /// </summary>
    class Invoker
    {
        ICommand command;

        /// <summary>
        /// method for setting command
        /// </summary>
        /// <param name="comand"></param>
        public void SetCommand(ICommand comand)
        {
           command = comand;
        }  

        /// <summary>
        /// method define which method will start
        /// </summary>
        public void StartMethod()
        {
            command.Execute();
        }
    }
}
