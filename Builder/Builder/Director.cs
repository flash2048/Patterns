using Builder.Computers;

namespace Builder
{
    class Director
    {
        public void Construct(BaseComputer computer)
        {
            computer.GetProcessor();
            computer.GetRom();
            computer.GetHdd();
            computer.GetVideoCard();
        }
    }
}
