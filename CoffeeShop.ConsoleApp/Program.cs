using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoffeeShop.Decorator;

namespace CoffeeShop.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CoffeeShop!");
            Console.WriteLine("----------------------");

            IBeverage beverage = null;
            Console.WriteLine("What beverage would you like?");
            Console.WriteLine("d: Dark Roast");
            Console.WriteLine("e: Espresso");
            Console.WriteLine("m: Mocha");
            var key = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine();
            switch (key)
            {
                case 'd': 
                    beverage = new DarkRoast();
                    break;
                case 'e':
                    beverage = new Espresso();
                    break;
                case 'm':
                    beverage = new Mocha();
                    break;
            }

            Console.WriteLine();
            if (null != beverage)
            {
                beverage = AskForCondiments(beverage);
                Console.WriteLine(String.Format("You ordered a {1}. That'll be: ${0:c}", beverage.Cost, beverage.Name));
            }
            Console.WriteLine();
            Console.WriteLine("Thank you, come again!");
            Console.ReadKey();
        }

        private static IBeverage AskForCondiments(IBeverage beverage)
        {
            var modifiedBeverage = beverage;
            char key = ' ';
            while(key != 'd')
            {
                Console.WriteLine(String.Format("You now have a {0}.", modifiedBeverage.Name));
                Console.WriteLine();
                Console.WriteLine("Would you like some condiments?");
                Console.WriteLine();
                Console.WriteLine("w: Whipped Cream");
                Console.WriteLine("s: Soy Milk");
                Console.WriteLine("v: Vanilla");
                Console.WriteLine("r: Remove the last one");
                Console.WriteLine("d: Done");
                key = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine();
                switch (key)
                {
                    case 'w':
                        modifiedBeverage = new WhippedCream(modifiedBeverage);
                        break;
                    case 'v':
                        modifiedBeverage = new VanillaSyrup(modifiedBeverage);
                        break;
                    case 's':
                        modifiedBeverage = new SoyMilk(modifiedBeverage);
                        break;
                    case 'r':
                        if (modifiedBeverage is CondimentDecorator)
                        {
                            modifiedBeverage = ((CondimentDecorator)modifiedBeverage).TheBeverage;                            
                        }
                        break;
                }
            }

            return modifiedBeverage;
        }
    }
}
