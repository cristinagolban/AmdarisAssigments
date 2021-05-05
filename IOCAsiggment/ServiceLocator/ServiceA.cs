using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocator
{
    public class ServiceA : IServiceA
    {
        public void Execute()
        {
            Console.WriteLine("A service called") ;
        }
    }
}
