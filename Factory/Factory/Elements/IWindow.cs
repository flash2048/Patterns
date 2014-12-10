using System;
using System.Collections.Generic;

namespace Factory.Elements
{
    public interface IWindow
    {
        String Name { get; set; }
        List<IWindowElement> ChildreElements { get;}
        void AddChild(IWindowElement child);
    }
}
