using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Dev_4
{
    /// <summary>
    /// Main class of program
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Entry point to program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Discipline agila = new Discipline();     
                Discipline physics = new Discipline();
                Console.WriteLine(agila.WriteText(20));

              //  Console.WriteLine(agila.Equals(physics));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error!: {ex.Message}");
            }
        }
    }
}
