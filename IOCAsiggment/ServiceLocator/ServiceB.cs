using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocator
{
    public class ServiceB : IServiceB
    {
        public void Execute()
        {
            Console.WriteLine("B service called");
        }
    }
}
