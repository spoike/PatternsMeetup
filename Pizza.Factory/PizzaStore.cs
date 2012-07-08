using System.Linq;
using System.Text;

namespace Pizza.Factory
{
    public abstract class PizzaStore
    {
        // This is the factory method
        // let the subclasses decide what exact type is created
        public abstract Pizza CreatePizza(PizzaType type);

        // This is an operation that calls the factory method
        public Pizza OrderPizza(PizzaType type)
        {
            var pizza = CreatePizza(type);

            if (null != pizza)
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();                
            }

            return pizza;
        }
    }
}
