using System;
using System.Collections.Generic;
using Factory.Elements;

namespace Factory.GUI
{
    public class StandartWindow : IWindow
    {
        public StandartWindow()
        {
            ChildreElements = new List<IWindowElement>();
            Name = "Standart window";

        }
        public StandartWindow(String name)
        {
            ChildreElements = new List<IWindowElement>();
            Name = name;
        }
        public string Name { get; set; }
        public List<IWindowElement> ChildreElements { get; set; }
        public void AddChild(IWindowElement child)
        {
            ChildreElements.Add(child);
        }
    }
}
