using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAT_2019._1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                string strfromcommandline = null;
                foreach (string element in args)
                {
                    strfromcommandline += element;
                }

                DifferentSimbols obj = new DifferentSimbols();
                obj.SearchDifferentSimbols(strfromcommandline);
            }

            else
            {
                Console.WriteLine("String must be longer than 2 simbol");
            }

            Console.Read();
        }
    }  
}
