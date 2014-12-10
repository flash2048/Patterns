using System;
using Factory.Elements;

namespace Factory.Client
{
    public class Client
    {
        public void Print(IWindow window)
        {
            Console.WriteLine(window.Name);
            foreach (var child in window.ChildreElements)
            {
                child.Print();
            }
        }

        public IWindow CreateWindow(IGUIFactory guiFactoryfactory)
        {
            var window = guiFactoryfactory.Window();
            var button = guiFactoryfactory.Button();
            var label = guiFactoryfactory.Label();

            window.AddChild(button);
            window.AddChild(label);
            return window;
        }
    }
}
