using Decorator.Models.Abstractions;

namespace Decorator.Models.Concretions.PizzaDecorations
{
    public class Cheese : PizzaDecorator
    {
        PizzaCounterpart _counterpart;

        public Cheese(PizzaCounterpart counterpart)
        {
            _counterpart = counterpart;
        }

        public override double Cost()
        {
            return _counterpart.Cost() + 1;
        }
    }
}
