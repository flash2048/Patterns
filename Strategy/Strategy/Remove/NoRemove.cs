using System;

namespace Strategy.Remove
{
    public class NoRemove:IRemoving
    {
        public void Remove()
        {
            Console.WriteLine("The user can not remove");
        }
    }
}
