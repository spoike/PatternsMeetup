namespace CoffeeShop.Decorator
{
    public abstract class CondimentDecorator : IBeverage
    {
        protected CondimentDecorator(IBeverage beverage)
        {
            TheBeverage = beverage;
        }

        public IBeverage TheBeverage { get; private set; }

        public decimal Cost
        {
            get { return TheBeverage.Cost + DecoratedCost; }
        }

        public string Name
        {
            get
            {
                return TheBeverage.Name + " " + DecoratedName;                
            }
        }

        protected abstract string DecoratedName { get; }

        protected abstract decimal DecoratedCost { get; }
    }

    public class WhippedCream : CondimentDecorator
    {
        public WhippedCream(IBeverage beverage) : base(beverage)
        {
        }

        protected override string DecoratedName
        {
            get { return "Whip"; }
        }

        protected override decimal DecoratedCost
        {
            get { return new decimal(0.2); }
        }
    }

    public class SoyMilk : CondimentDecorator
    {
        public SoyMilk(IBeverage beverage) : base(beverage)
        {
        }

        protected override string DecoratedName
        {
            get { return "Soy"; }
        }

        protected override decimal DecoratedCost
        {
            get { return new decimal(0.3); }
        }
    }

    public class VanillaSyrup : CondimentDecorator
    {
        public VanillaSyrup(IBeverage beverage) : base(beverage)
        {
        }

        protected override string DecoratedName
        {
            get { return "Vanilla"; }
        }

        protected override decimal DecoratedCost
        {
            get { return new decimal(0.4); }
        }
    }
}