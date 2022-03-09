using DecoraterPattern.Beverages;

namespace DecoraterPattern.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract string getDescription();
    }
}
