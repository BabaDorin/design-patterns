using PizzaOrdering.Counterparts;
using PizzaOrdering.Ingredients;

// Pizza #1: Large counterpart + mushrooms.
Counterpart firstPizza = new LargeCounterpart();

// Decorate the counterpart with some mushrooms
firstPizza = new Mushrooms(firstPizza);

// Output: $7 + $3 = $10
Console.WriteLine(firstPizza.Cost());


// Pizza #2: Small Counterpart with mushrooms and two servings of salami
Counterpart secondPizza = new SmallCounterpart();

// Decorate the pizza with some mushrooms
secondPizza = new Mushrooms(secondPizza);

// Let's add some salami
secondPizza = new Salami(secondPizza);

// Let's add even more salami
secondPizza = new Salami(secondPizza);

// Output: $5 + $3 + $6 + $6 = $20
Console.WriteLine(secondPizza.Cost());