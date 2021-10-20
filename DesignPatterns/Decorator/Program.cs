using Decorator.Models.Concretions.PizzaCounterparts;
using Decorator.Models.Concretions.PizzaDecorations;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // What's the cost of a YOUUGE pizza with tomatoes, olive oil and 2 portions of cheese?
            double cost = new Cheese(new Cheese(new OliveOil(new Tomato(new YougePizzaCounterpart())))).Cost();
            // output: 8.5
            
            // Not using decorator pattern in such cases might result in a so called 'Class explosion'.
            // Imagine having a bunch of classes, including YougePizzaWithTomatoOliveOilAndTwoPortionsOfCheese, just to get 
            // the behavior of Cost method of this combination.
            Console.WriteLine(cost);
        }
    }
}
