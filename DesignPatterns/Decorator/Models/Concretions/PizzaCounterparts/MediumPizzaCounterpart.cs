using Decorator.Models.Abstractions;

namespace Decorator.Models.Concretions.PizzaCounterparts
{
    public class MediumPizzaCounterpart : PizzaCounterpart
    {
        public override double Cost()
        {
            return 4.7;
        }
    }
}
