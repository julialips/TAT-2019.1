using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Invoker
    {
        ICommand command;

        public void SetCommand(ICommand comand)
        {
           command = comand;
        }  

        public void StartMethod()
        {
            command.Execute();
        }
    }
}
