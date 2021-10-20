using Decorator.Models.Abstractions;

namespace Decorator.Models.Concretions.PizzaCounterparts
{
    public class YougePizzaCounterpart : PizzaCounterpart
    {
        public override double Cost()
        {
            return 6.2;
        }
    }
}
