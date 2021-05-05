using System;

namespace IOCAsiggment
{
    class Program
    {
        static void Main(string[] args)
        {
            UserBusinessLogic user1 = new UserBusinessLogic();
            Console.WriteLine(user1.ProcessUserData(2));
        }
    }
}
