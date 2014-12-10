using System;
namespace Facade.Microwave
{
    class Notification
    {
        public void StopNotification()
        {
            Console.WriteLine("Пик-пик-пик - операция завершена");
        }
        public void StartNotification()
        {
            Console.WriteLine("Пик - начат процесс готовки");
        }
    }
}
