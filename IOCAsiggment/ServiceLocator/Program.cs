using System;

namespace ServiceLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceLocator loc = new ServiceLocator();
            IServiceA Aservice = loc.GetService<IServiceA>();
            Aservice.Execute();

            IServiceB Bservice = loc.GetService<IServiceB>();
            Bservice.Execute();
        }
    }
}
