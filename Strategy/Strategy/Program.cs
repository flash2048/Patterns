using System;
using System.Collections.Generic;
using Strategy.Users;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            var users = new List<User>();
            users.Add(new Administrator());
            users.Add(new Editor());
            users.Add(new Guest());

            foreach (var user in users)
            {
                user.Who();
                user.Read();
                user.Add();
                user.Edit();
                user.Remove();

                Console.WriteLine("------------");
            }
        }
    }
}
