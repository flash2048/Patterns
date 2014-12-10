using Decorator.Auto;

namespace Decorator.Decorators
{
    class Tires:Options
    {
        private readonly AutoBase _autoBase;

        public Tires(AutoBase autoBase)
        {
            _autoBase = autoBase;
            if (autoBase != null)
            {
                Description = autoBase.GetDescription() + " + покрышки на зиму";
            }
        }

        public override double GetCost()
        {
            double cost = 220;
            if (_autoBase != null)
            {
                cost += _autoBase.GetCost();
            }
            return cost;
        }
    }
}
