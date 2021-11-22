using PizzaOrdering.Counterparts;

namespace PizzaOrdering.Ingredients
{
    public abstract class Ingredient : Counterpart
    {
        protected readonly Counterpart _counterPart;

        public Ingredient(Counterpart counterpart)
        {
            _counterPart = counterpart;
        }
    }
}
