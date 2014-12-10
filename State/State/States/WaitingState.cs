using System;

namespace State.States
{
    class WaitingState : IState
    {
        private readonly Printer _printer;

        public WaitingState(Printer printer)
        {
            _printer = printer;
        }

        public void On()
        {
            Console.WriteLine("Принтер уже и так включен");
        }

        public void Off()
        {
            Console.WriteLine("Принтер выключен");
        }

        public void Print()
        {
            if (_printer.CountPaper > 0)
            {
                Console.WriteLine("Сейчас всё распечатаем");
                _printer.AddPater(-1);
            }
            else
            {
                _printer.SetState(_printer.PaperOffState);
                _printer.PrintDocument();
            }
        }

        public void AddPaper(int count)
        {
            _printer.AddPater(count);
            Console.WriteLine("Бумага добавлена");
        }
    }
}
