using System;
using Facade.Microwave;

namespace Facade
{
    class Program
    {
        static void Main()
        {
            var drive = new Drive();
            var power = new Power();
            var notification = new Notification();

            var microwave = new Microwave.Microwave(drive, power, notification);

            Console.WriteLine("Разморозим");
            microwave.Defrost();
            Console.WriteLine();
            Console.WriteLine("Подогреем");
            microwave.Heating();
        }
    }
}
