using System;
using System.Collections.Generic;

namespace Pizza.Factory
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        protected string Dough { get; set; }
        protected string Sauce { get; set; }

        private readonly List<string> _toppings = new List<string>(); 
        
        protected void AddTopping(string topping)
        {
            _toppings.Add(topping);
        }

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings...");
            foreach (var topping in _toppings)
            {
                Console.WriteLine("    " + topping);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}