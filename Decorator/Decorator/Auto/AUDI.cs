namespace Decorator.Auto
{
    class AUDI: AutoBase
    {

        public AUDI()
        {
            Description = "Audi A8 — автомобиль представительского класса, преемник модели Audi V8";
        }

        public override double GetCost()
        {
            return 31500;
        }
    }
}
