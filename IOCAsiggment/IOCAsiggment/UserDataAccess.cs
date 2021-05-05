using System;
using System.Collections.Generic;
using System.Text;

namespace IOCAsiggment
{
    public class UserDataAccess : IUserDataAccess
    {
        public UserDataAccess()
        {

        }

        public int GetUserAge(int id)
        {
            return 25;
        }

        public string GetUserName(int id)
        {
            return $"Name of user with id {id}";
        }
    }
}
