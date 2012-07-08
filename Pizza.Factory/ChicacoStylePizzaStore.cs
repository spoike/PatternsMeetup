namespace Pizza.Factory
{
    public class ChicacoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType type)
        {
            if (type == PizzaType.Cheese)
            {
                return new ChicagoStyleCheesePizza();
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