using System;

namespace Decorator.Auto
{
    public abstract class AutoBase
    {

        protected String Description = "";

        public String GetDescription()
        {
            return Description;
        }

        public abstract double GetCost();
    }
}
