using Decorator.Models.Abstractions;

namespace Decorator.Models.Concretions.PizzaDecorations
{
    public class Tomato : PizzaDecorator
    {
        PizzaCounterpart _counterpart;

        public Tomato(PizzaCounterpart counterpart)
        {
            _counterpart = counterpart;
        }

        public override double Cost()
        {
            return _counterpart.Cost() + 0.2;
        }
    }
}
