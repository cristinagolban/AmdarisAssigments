using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocator
{
    public class ProductService : IProductService
    {
        public void Execute()
        {
            Console.WriteLine("Product Service service called") ;
        }
    }
}
