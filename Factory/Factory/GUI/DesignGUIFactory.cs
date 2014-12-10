using Factory.Elements;

namespace Factory.GUI
{
    public class DesignGUIFactory: IGUIFactory
    {
        public IWindow Window()
        {
            return new DesignWindow();
        }

        public ILabel Label()
        {
            return new DesignLabel();
        }

        public IButton Button()
        {
            return new DesignButton();
        }
    }
}
