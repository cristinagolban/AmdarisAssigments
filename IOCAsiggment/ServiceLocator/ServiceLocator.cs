using System;
using System.Collections.Generic;
using System.Text;
using Ninject;



namespace ServiceLocator
{
    public class ServiceLocator 
    {
        private static readonly IKernel Kernel = new StandardKernel();

        public static void RegisterAll()
        {
            Kernel.Bind<IProductService>().To<ProductService>();
            Kernel.Bind<IComandService>().To<ComandService>();


        }

        public static T Resolve<T>()
        {
            return Kernel.Get<T>();
        }
       
    }
}
