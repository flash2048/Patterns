using System;

namespace Factory.Elements
{
    public interface IWindowElement
    {
        String Text { get; set; }
        void Print();
    }
}
