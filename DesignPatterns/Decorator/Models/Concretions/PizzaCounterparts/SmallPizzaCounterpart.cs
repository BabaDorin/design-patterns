using Decorator.Models.Abstractions;

namespace Decorator.Models.Concretions.PizzaCounterparts
{
    public class SmallPizzaCounterpart : PizzaCounterpart
    {
        public override double Cost()
        {
            return 4.5;
        }
    }
}
