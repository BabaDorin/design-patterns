using PizzaOrdering.Counterparts;

namespace PizzaOrdering.Ingredients
{
    public class Mushrooms : Ingredient
    {
        public Mushrooms(Counterpart counterpart)
            : base(counterpart)
        {
        }

        public override double Cost() => _counterPart.Cost() + 3;
    }
}
