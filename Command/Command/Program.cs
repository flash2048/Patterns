using System;
using Command.Commands;

namespace Command
{
    class Program
    {
        static void Main()
        {
            var tv = new CommandTv("Телевизор в гостиной");
            var tv2 = new CommandTv("Телевизор в спальне");
            var tv3 = new CommandTv("Телевизор на кухне");

            var light = new CommandLight("Свет в гостиной");
            var light2 = new CommandLight("Свет в спальне");
            var light3 = new CommandLight("Свет на кухне");
            

            var remoteControl = new RemoteControl();
            remoteControl.AddDevice(1, tv);
            remoteControl.AddDevice(2, light);
            remoteControl.AddDevice(3, tv2);
            remoteControl.AddDevice(4, light2);
            remoteControl.AddDevice(5, tv3);
            remoteControl.AddDevice(6, light3);
           
            remoteControl.PrintMenu();

            var input = Console.ReadLine();


            while (input != "0")
            {
                if (input != null)
                {
                    var button = Int32.Parse(input);
                    remoteControl.RunCommand(button);
                }
                input = Console.ReadLine();
            }
        }
    }
}
