using System;

namespace Command.Controlled
{
    public class Tv
    {
        public void TurnOn()
        {
            Console.WriteLine("Телевизор включен");
            State = State.On;
        }
        public void TurnOf()
        {
            Console.WriteLine("Телевизор выключен");
            State = State.Off;
        }
        public State State { get; set; }
    }
}
