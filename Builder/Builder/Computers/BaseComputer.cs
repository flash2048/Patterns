namespace Builder.Computers
{
    public abstract class BaseComputer
    {
        public abstract void GetProcessor();
        public abstract void GetRom();
        public abstract void GetHdd();
        public abstract void GetVideoCard();
    }
}
