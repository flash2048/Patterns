namespace Decorator.Auto
{
    class BMW: AutoBase
    {

        public BMW()
        {
            Description = "BMW X5 — среднеразмерный кроссовер от немецкого автопроизводителя";
        }

        public override double GetCost()
        {
            return 25000;
        }
    }
}
