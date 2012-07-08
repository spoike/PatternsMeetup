using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pizza.Factory;

namespace Pizza.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NewYorkStylePizzaStore();
            PizzaStore chicagoStore = new ChicacoStylePizzaStore();

            var pizza = nyStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine("Ethan ordered a " + pizza.Name);
            Console.WriteLine();

            pizza = chicagoStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine("Joel ordered a " + pizza.Name);
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
