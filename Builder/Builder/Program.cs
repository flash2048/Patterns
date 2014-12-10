using System;
using Builder.Computers;

namespace Builder
{
    class Program
    {
        static void Main()
        {
            var director = new Director();
            var standartComputer = new StandartComputer();
            var premiumComputer = new PremiumComputer();

            Console.WriteLine("--Надо собрать обычный компьютер");
            director.Construct(standartComputer);
            Console.WriteLine("\n--Надо собрать дорогой и мощный компьютер");
            director.Construct(premiumComputer);
        }
    }
}
