using System;
using System.Collections.Generic;
using System.Text;


namespace ServiceLocator
{
    public class ServiceLocator : IService
    {
        public Dictionary<object, object> servicecontainer = null;
        public ServiceLocator()
        {
            servicecontainer = new Dictionary<object, object>();
            servicecontainer.Add(typeof(IServiceA), new ServiceA());
            servicecontainer.Add(typeof(IServiceB), new ServiceB());
        }
        public T GetService<T>()
        {
             


            try
            {
                return (T)servicecontainer[typeof(T)];
            }
            catch (Exception ex)
            {
                throw new NotImplementedException("Service not available.");
            }
        }
    }
}
