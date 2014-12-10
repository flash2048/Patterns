using System;
namespace State.States
{
    class PowerOffState : IState
    {
        private readonly Printer _printer;

        public PowerOffState(Printer printer)
        {
            _printer = printer;
        }
        public void On()
        {
            Console.WriteLine("Принтер включен");
            _printer.SetState(_printer.WaitingState);
        }

        public void Off()
        {
            Console.WriteLine("Принтер и так выключен");
        }

        public void Print()
        {
            Console.WriteLine("Принтер отключен, печать невозможна");
        }

        public void AddPaper(int count)
        {
            _printer.AddPater(count);
            Console.WriteLine("Бумага добавлена");
        }
    }
}
