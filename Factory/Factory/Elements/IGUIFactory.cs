namespace Factory.Elements
{
    public interface IGUIFactory
    {
        IWindow Window();
        ILabel Label();
        IButton Button();
    }
}
