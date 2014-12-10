using System;
using Strategy.Add;
using Strategy.Edit;
using Strategy.Remove;

namespace Strategy.Users
{
    public abstract class User
    {
        protected IAdding addBehaviour;
        protected IEditing editBehaviour;
        protected IRemoving removeBehaviour;

        public User()
        {
            addBehaviour = new NoAdd();
            editBehaviour = new NoEdit();
            removeBehaviour = new NoRemove();
        }

        public void Read()
        {
            Console.WriteLine("I read...");
        }

        public void Add()
        {
            addBehaviour.Add();
        }

        public void Edit()
        {
            editBehaviour.Edit();
        }

        public void Remove()
        {
            removeBehaviour.Remove();
        }

        public abstract void Who();
    }
}
