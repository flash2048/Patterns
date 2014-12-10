using System;
namespace Strategy.Add
{
    public class NoAdd:IAdding
    {
        public void Add()
        {
            Console.WriteLine("User can not add");
        }
    }
}
