using PizzaOrdering.Counterparts;

namespace PizzaOrdering.Ingredients
{
    public class Salami : Ingredient
    {
        public Salami(Counterpart counterpart)
            : base(counterpart)
        {

        }

        public override double Cost() => _counterPart.Cost() + 6;
    }
}
