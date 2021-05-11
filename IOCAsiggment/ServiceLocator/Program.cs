using System;

namespace ServiceLocator
{
   public class Program
    {
        public Program()
        {
            ServiceLocator.RegisterAll();
        }
        static void Main(string[] args)
        {
            var command = ServiceLocator.Resolve<IProductService>();
            
            
        }
    }
}
