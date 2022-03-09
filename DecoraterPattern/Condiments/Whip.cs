using DecoraterPattern.Beverages;

namespace DecoraterPattern.Condiments
{
    public class Whip : CondimentDecorator
    {
        readonly Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + " Whip";
        }
        public override double cost()
        {
            return 0.10 + beverage.cost();
        }
    }
}
