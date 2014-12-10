using System;
namespace Builder.Computers
{
    class StandartComputer:BaseComputer
    {
        public override void GetProcessor()
        {
            Console.WriteLine("Intel i3");
        }

        public override void GetRom()
        {
            Console.WriteLine("4Gb");
        }

        public override void GetHdd()
        {
            Console.WriteLine("500Gb");
        }

        public override void GetVideoCard()
        {
            Console.WriteLine("GeForce GT 730");
        }
    }
}
