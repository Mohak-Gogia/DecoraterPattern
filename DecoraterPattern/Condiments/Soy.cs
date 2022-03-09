using DecoraterPattern.Beverages;

namespace DecoraterPattern.Condiments
{
    public class Soy : CondimentDecorator
    {
        readonly Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + " Soy";
        }
        public override double cost()
        {
            return 0.15 + beverage.cost();
        }
    }
}
