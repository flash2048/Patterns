using System;
using SingletonPattern.Session;

namespace SingletonPattern
{
    class Program
    {
        static void Main()
        {
            MySession.Instance["user"] = "Андрей";
            MySession.Instance["role"] = "admin";

            Console.WriteLine(MySession.Instance.DateStart);
            Console.WriteLine(MySession.Instance["user"]);
            Console.WriteLine(MySession.Instance["role"]);
            Console.WriteLine(MySession.Instance.DateStart);
            Console.WriteLine(MySession.Instance.DateStart);
        }
    }
}
