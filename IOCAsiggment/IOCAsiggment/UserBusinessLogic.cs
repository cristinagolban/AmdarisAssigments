using System;
using System.Collections.Generic;
using System.Text;

namespace IOCAsiggment
{
    public class UserBusinessLogic
    {
        IUserDataAccess _dataaccess;

        public UserBusinessLogic(IUserDataAccess DataAccess)
        {
            _dataaccess = DataAccess;

        }

        public UserBusinessLogic()
        {
            _dataaccess = new UserDataAccess();
        }

        public string ProcessUserData(int id)
        {
            return _dataaccess.GetUserName(id);
            
        }

        public int ProcessUserData2(int id)
        {
            return _dataaccess.GetUserAge(id);
        }
    }
}
