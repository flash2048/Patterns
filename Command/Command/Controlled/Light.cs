using System;

namespace Command.Controlled
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Свет включен");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Свет выключен");
            State = State.Off;
        }

        public State State { get; set; }
    }
}
