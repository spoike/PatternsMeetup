using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.Decorator
{
    /// <summary>
    /// The component Beverage with a cost attribute
    /// </summary>
    public interface IBeverage
    {

        decimal Cost { get; }

        string Name { get; }

    }

    public class Mocha : IBeverage
    {
        public decimal Cost
        {
            get
            {
                return new decimal(1.0);
            }
        }

        public string Name
        {
            get
            {
                return "Mocha";
            }
        }
    }

    public class DarkRoast : IBeverage
    {
        public decimal Cost
        {
            get { return new decimal(1.2); }
        }

        public string Name
        {
            get { return "Dark Roast"; }
        }
    }

    public class Espresso : IBeverage
    {
        public decimal Cost
        {
            get { return new decimal(1.6); }
        }

        public string Name
        {
            get { return "Espresso"; }
        }
    }
}
