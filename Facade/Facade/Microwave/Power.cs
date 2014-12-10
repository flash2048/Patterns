using System;

namespace Facade.Microwave
{
    class Power
    {
        private int _power;
        public int MicrowavePower {
            get { return _power; }
            set
            {
                _power = value;
                Console.WriteLine("Задана мощность {0}w ", _power);
            }
        }

    }
}
