using DecoraterPattern.Beverages;

namespace DecoraterPattern.Condiments
{
    public class Mocha : CondimentDecorator
    {
        readonly Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + " Mocha";
        }
        public override double cost()
        {
            return 0.20 + beverage.cost();
        }
    }
}
