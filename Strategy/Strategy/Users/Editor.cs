using System;
using Strategy.Edit;

namespace Strategy.Users
{
    public class Editor:User
    {
        public Editor()
        {
            editBehaviour = new Editing();
        }

        public override void Who()
        {
           Console.WriteLine("I am editor...");
        }
    }
}
