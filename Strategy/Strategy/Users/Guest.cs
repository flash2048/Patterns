using System;

namespace Strategy.Users
{
    public class Guest:User
    {
        public override void Who()
        {
            Console.WriteLine("I am guest...hello...");
        }
    }
}
