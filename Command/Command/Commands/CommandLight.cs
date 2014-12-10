using System;
using Command.Controlled;

namespace Command.Commands
{
    public class CommandLight : ICommand
    {
        private Light _light;
        private string _name;
        public CommandLight(String name)
        {
            _light = new Light();
            _name = name;
        }
        public CommandLight(Light light, String name)
        {
            _light = light;
            _name = name;
        }

        public void Execute()
        {
            switch (_light.State)
            {
                case State.On:
                    _light.TurnOff();
                    break;
                case State.Off:
                    _light.TurnOn();
                    break;
            }
        }

        public void Undo()
        {
            switch (_light.State)
            {
                case State.On:
                    _light.TurnOff();
                    break;
                case State.Off:
                    _light.TurnOn();
                    break;
            }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
