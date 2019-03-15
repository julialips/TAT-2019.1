using System;
using System.Text;


namespace Task2
{
    class RushianRules
    {
       public void ConvertToPhonemes(string[] args)
        {
         for(int i = 0; i < args.Length; i++)
            {
                args[i] = null;
                switch (args[i])
                {
                    case "л,м,н" :
                        string newstr = args[i];
                        meth1(newstr);
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
             void meth1(string newstr)
            {
                Console.WriteLine(newstr);
            }
        




        }

    }
}
