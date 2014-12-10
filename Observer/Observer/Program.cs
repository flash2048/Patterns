using System;
using Observer.Content;
using Observer.Devices;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            var wp1 = new WindowsPhone("Lumia 620");
            var wp2 = new WindowsPhone("Lumia 1020");
            var wp3 = new WindowsPhone("Lumia 930");

            var android1 = new AndroidPhone("Nexus 4");
            var android2 = new AndroidPhone("Nexus 5");
            var android3 = new AndroidPhone("Galaxy 3");

            var observer = new Messages();

            //Подписываем на уведомления Windows Phone девайсы
            observer.ContentChanged += wp1.Update;
            observer.ContentChanged += wp2.Update;
            observer.ContentChanged += wp3.Update;

            //Подписываем на уведомления Android девайсы
            observer.ContentChanged += android1.Update;
            observer.ContentChanged += android2.Update;
            observer.ContentChanged += android3.Update;

            
            //Первое PUSH уведомление
            observer.MessageAvailable();

            //Удаляем из рассылки Lumia 620 и Nexus 4
            observer.ContentChanged -= wp1.Update;
            observer.ContentChanged -= android1.Update;

            Console.WriteLine("\n---Были удалены некоторые девайсы из рассылки---");

            //Второе PUSH уведомление
            observer.MessageAvailable();
            Console.WriteLine("\n---Третья рассылка---");
            //Третья рассылка
            observer.MessageAvailable();
        }
    }
}
