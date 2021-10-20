using Decorator.Models.Abstractions;

namespace Decorator.Models.Concretions.PizzaCounterparts
{
    public class LargePizzaCounterpart : PizzaCounterpart
    {
        public override double Cost()
        {
            return 5;
        }
    }
}
