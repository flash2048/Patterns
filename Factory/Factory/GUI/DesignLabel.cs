﻿using System;
using Factory.Elements;

namespace Factory.GUI
{
    public class DesignLabel: ILabel
    {
         public DesignLabel()
        {
            Text = "New Label";
        }
         public DesignLabel(String text)
        {
            Text = text;
        }
        public string Text { get; set; }
        public void Print()
        {
            Console.WriteLine("!!!- {0} -!!!", Text.ToUpper());
        }
    }
}
