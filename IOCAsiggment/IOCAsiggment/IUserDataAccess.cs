using System;
using System.Collections.Generic;
using System.Text;

namespace IOCAsiggment
{
    public interface IUserDataAccess
    {

        string GetUserName(int id);

        int GetUserAge(int id);
    }
}
