using Decorator.Models.Abstractions;

namespace Decorator.Models.Concretions.PizzaDecorations
{
    public class Ketchup : PizzaDecorator
    {
        PizzaCounterpart _counterpart;

        public Ketchup(PizzaCounterpart counterpart)
        {
            _counterpart = counterpart;
        }

        public override double Cost()
        {
            return _counterpart.Cost() + 0.3;
        }
    }
}
