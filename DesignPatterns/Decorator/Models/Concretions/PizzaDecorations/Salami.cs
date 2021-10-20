using Decorator.Models.Abstractions;

namespace Decorator.Models.Concretions.PizzaDecorations
{
    public class Salami : PizzaDecorator
    {
        PizzaCounterpart _counterpart;

        public Salami(PizzaCounterpart counterpart)
        {
            _counterpart = counterpart;
        }

        public override double Cost()
        {
            return _counterpart.Cost() + 0.7;
        }
    }
}
