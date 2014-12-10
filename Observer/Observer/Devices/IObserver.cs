using System;

namespace Observer.Devices
{
    interface IObserver
    {
        void Display();
        void Update(object sender, String message);
    }
}
