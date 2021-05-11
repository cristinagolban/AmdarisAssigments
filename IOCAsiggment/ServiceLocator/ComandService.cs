using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocator
{
    public class ComandService : IComandService
    {
        public void Execute()
        {
            Console.WriteLine("Comand Service service called");
        }
    }
}
