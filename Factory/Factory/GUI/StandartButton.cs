using System;
using Factory.Elements;

namespace Factory.GUI
{
    public class StandartButton : IButton
    {
        public StandartButton()
        {
            Text = "New Button";
        }
        public StandartButton(String text)
        {
            Text = text;
        }
        public string Text { get; set; }
        public void Print()
        {
            Console.WriteLine("<{0}>", Text);
        }
    }
}
