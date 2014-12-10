using System;
namespace Strategy.Edit
{
    public class NoEdit:IEditing
    {
        public void Edit()
        {
            Console.WriteLine("The user can not edit");
        }
    }
}
