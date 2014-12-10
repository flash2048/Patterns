using System;
using Strategy.Add;
using Strategy.Edit;
using Strategy.Remove;

namespace Strategy.Users
{
   public class Administrator:User
    {
        public Administrator()
        {
            addBehaviour = new Adding();
            editBehaviour = new Editing();
            removeBehaviour = new Removing();
        }

        public override void Who()
        {
            Console.WriteLine("I am administrator!");
        }
    }
}
