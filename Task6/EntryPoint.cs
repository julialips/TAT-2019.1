using System;

namespace Task6
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                CommandSelection commandSelection = new CommandSelection(args[0]);
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Error! You didn't put name XML-file");
            }
        }
    }
}
