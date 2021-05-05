using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocator
{
    public interface IService
    {
        T GetService<T>();
    }
}
