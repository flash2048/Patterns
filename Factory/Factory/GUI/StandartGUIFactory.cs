using Factory.Elements;

namespace Factory.GUI
{
    public class StandartGUIFactory: IGUIFactory
    {
        public IWindow Window()
        {
           return new StandartWindow();
        }

        public ILabel Label()
        {
            return new StandartLabel();
        }

        public IButton Button()
        {
            return new StandartButton();
        }
    }
}
