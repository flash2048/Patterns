using System;
using Adapter.Adapters;

namespace Adapter
{
    public static class UserProfile
    {
        public static void PrintUserInfo(IAdapter user)
        {
            Console.WriteLine("Имя пользователя: \t\t {0}", user.Name);
            Console.WriteLine("Возраст: \t\t\t {0}", user.Age);
            Console.WriteLine("Количество друзей: \t\t {0}", user.NumberOfFriends);
            Console.WriteLine("--- --- --- --- --- ---");
        }
    }
}
