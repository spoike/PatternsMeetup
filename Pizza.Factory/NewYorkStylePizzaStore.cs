namespace Pizza.Factory
{
    public class NewYorkStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType type)
        {
            if (type == PizzaType.Cheese)
            {
                return new NewYorkStyleCheesePizza();
            }
            /*
            if (type == PizzaType.Pepperoni)
            {
                return new NewYorkStylePepperoniPizza();
            }
            if (type == PizzaType.Clam)
            {
                return new NewYorkStyleClamPizza();
            }
            if (type == PizzaType.Veggie)
            {
                return new NewYorkStyleVeggiePizza();
            }
             * */
            return null;
        }
    }
}