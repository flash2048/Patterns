using System;
using System.Collections.Generic;
using Factory.Elements;

namespace Factory.GUI
{
    public class DesignWindow:IWindow
    {
        public DesignWindow()
        {
            ChildreElements = new List<IWindowElement>();
            Name = "Desig window";
          
        }
        public DesignWindow(String name)
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
