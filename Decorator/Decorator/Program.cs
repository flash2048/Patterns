using System;
using Decorator.Auto;
using Decorator.Decorators;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            var auto1 = new BMW();
            var auto2 = new AUDI();

            PrintAuto(auto1);
            PrintAuto(auto2);
            Console.WriteLine("----------------------------------");

            var auto3 = new Insurance(new BMW());
            var auto4 = new Conditioner(new Tires(new AUDI()));
            var auto5 = new Tires(new Conditioner(new Insurance(new BMW())));
            PrintAuto(auto3);
            PrintAuto(auto4);
            PrintAuto(auto5);
        }

        public static void PrintAuto(AutoBase auto)
        {
            Console.WriteLine("{0} \nСтоимость: {1}$", auto.GetDescription(), auto.GetCost());
            Console.WriteLine("---");
        }
    }
}
