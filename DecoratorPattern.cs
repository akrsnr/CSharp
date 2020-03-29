using System;
using System.Collections.Generic;
using System.Linq;

namespace DecTest
{
    public interface Coffee
    {
        public double getCost();        // Returns the cost of the coffee
        public string getIngredients(); // Returns the ingredients of the coffee
    }

// Extension of a simple coffee without any extra ingredients
    public class SimpleCoffee : Coffee
    {
        public double getCost()
        {
            return 1;
        }

        public string getIngredients()
        {
            return "Coffee";
        }
    }

    public abstract class CoffeeDecorator : Coffee
    {
        private Coffee decoratedCoffee;

        public CoffeeDecorator(Coffee c)
        {
            this.decoratedCoffee = c;
        }

        public virtual double getCost()
        {
            // Implementing methods of the interface
            return decoratedCoffee.getCost();
        }

        public virtual string getIngredients()
        {
            return decoratedCoffee.getIngredients();
        }
    }

    class WithMilk : CoffeeDecorator
    {
        public WithMilk(Coffee c) :
            base(c)

        {
        }

        public override double getCost()
        {
            // Overriding methods defined in the abstract superclass
            return base.getCost() + 0.5;
        }

        public override string getIngredients()
        {
            return base.getIngredients() + ", Milk";
        }
        
    }

    class WithSprinkles : CoffeeDecorator
    {
        public WithSprinkles(Coffee c) : base(c)
        {
        }

        public override double getCost()
        {
            return base.getCost() + 0.2;
        }

        public override string getIngredients()
        {
            return base.getIngredients() + ", Sprinkles";
        }
    }

    public class MainClass
    {
        public static void printInfo(Coffee c)
        {
            Console.WriteLine("Cost: " + c.getCost() + "; Ingredients: " + c.getIngredients());
        }

        public static void Main(String[] args)
        {
            Coffee c = new SimpleCoffee();
            printInfo(c);

            c = new WithMilk(c);
            printInfo(c);

            c = new WithSprinkles(c);
            printInfo(c);
            
            var x = new WithSprinkles(new WithMilk(new SimpleCoffee())).getCost();
        }
    }
    


}
