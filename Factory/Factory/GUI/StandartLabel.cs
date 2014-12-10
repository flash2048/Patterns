using System;
using Factory.Elements;

namespace Factory.GUI
{
    public class StandartLabel: ILabel
    {
         public StandartLabel()
        {
            Text = "New Button";
        }
         public StandartLabel(String text)
        {
            Text = text;
        }
        public string Text { get; set; }
        public void Print()
        {
            Console.WriteLine(":{0}", Text);
        }
    }
}
