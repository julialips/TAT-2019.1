using System;

namespace Task6
{
    /// <summary>
    /// Main class of program
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Entry poin of program
        /// </summary>
        /// <param name="args"> name of xml file </param>
        static void Main(string[] args)
        {
            try
            {
                ReaderFromXML readerFromXML = new ReaderFromXML();
                readerFromXML.Read(args[0]);
                CommandSelection commandSelection = new CommandSelection(args[0]);
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Error! You didn't put name XML-file");
            }
        }
    }
}
