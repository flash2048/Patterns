using Decorator.Auto;

namespace Decorator.Decorators
{
    class Conditioner:Options
    {
        private readonly AutoBase _autoBase;

        public Conditioner(AutoBase autoBase)
        {
            _autoBase = autoBase;
            if (autoBase != null)
            {
                Description = autoBase.GetDescription() + " + кондиционер";
            }
        }

        public override double GetCost()
        {
            double cost = 150;
            if (_autoBase != null)
            {
                cost += _autoBase.GetCost();
            }
            return cost;
        }
    }
}
