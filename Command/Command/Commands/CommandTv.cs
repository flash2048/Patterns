using System;
using Command.Controlled;

namespace Command.Commands
{
    class CommandTv : ICommand
    {
        private readonly Tv _tv;
        private string _name;
        public CommandTv(String name)
        {
            _tv = new Tv();
            _name = name;
        }

        public CommandTv(Tv tv, String name)
        {
            _tv = tv;
            _name = name;
        }

        public void Execute()
        {
            switch (_tv.State)
            {
                case State.On:

                    _tv.TurnOf();
                    break;
                case State.Off:

                    _tv.TurnOn();
                    break;
            }
        }

        public void Undo()
        {
            switch (_tv.State)
            {
                case State.On:
                    _tv.TurnOf();
                    break;
                case State.Off:
                    _tv.TurnOn();
                    break;
            }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
