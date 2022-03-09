namespace DecoraterPattern.Beverages
{
    public abstract class Beverage
    {
        public string description;
        public abstract double cost();

        public virtual string getDescription()
        {
            return description;
        }
    }
}
