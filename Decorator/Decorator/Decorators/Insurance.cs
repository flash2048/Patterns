using Decorator.Auto;

namespace Decorator.Decorators
{
    class Insurance:Options
    {
        private readonly AutoBase _autoBase;

        public Insurance(AutoBase autoBase)
        {
            _autoBase = autoBase;
            if (autoBase != null)
            {
                Description = autoBase.GetDescription() + " + СТРАХОВКА на год";
            }
        }

        public override double GetCost()
        {
            double cost = 500;
            if (_autoBase != null)
            {
                cost += _autoBase.GetCost();
            }
            return cost;
        }
    }
}
