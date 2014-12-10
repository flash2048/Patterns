using System;

namespace Builder.Computers
{
    class PremiumComputer:BaseComputer
    {
        public override void GetProcessor()
        {
            Console.WriteLine("Intel i7");
        }

        public override void GetRom()
        {
            Console.WriteLine("16Gb");
        }

        public override void GetHdd()
        {
            Console.WriteLine("2Tb");
        }

        public override void GetVideoCard()
        {
            Console.WriteLine("GeForce GTX 980");
        }
    }
}
