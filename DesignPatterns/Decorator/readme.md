# Decorator pattern
The analysis will be added soon.

These are just some snippets

Definition: The decorator pattern attaches additional responsibilities to an object dynamically. 
Decorators provide a flexible alternative to subclassing for externaling functionality.

Our goal is to allow classes to be easily extended to 
incorporate new behavior without modifying existing code (Remember Open-Closed principle?).

This is an example where Decorator pattern suits perfectly:

Imagine you have to design an application for a restaurant. The restaurant owner asked you to add a feature that will allow
users to specify the ingredients of a pizza instead of ordering an existing pizza setup (like capriciosa, margherita etc.)

The user will be given an empty pizza counterpart, and he is free to "design" it however he wants.

1. Pizza counterpart is our component, and it costs $5.

Now, let's add the **decorators**:
- Add ketchup - extra $0.3
- Add Olive oil - extra $0.1
- Add Tomatoes - extra $0.2
- Add cheese - extra $1
- Add salami - extra $0.7
- And so on..

Following the Decorator Design Pattern, these decorators will get attached to the main component - pizza counterpart.
Say we're interested in the final cost of the pizza. It will be very easy to get that information because each decorator appends it's cost
to the previous state:
Ex: 
Counterpart = 5$,
Counterpart + Ketchup = $5.3
(Counterpart + Ketcup) + Olive oil = $5.4
((Counterpart + Ketchup) + Olive oil) + Tomatoes = $5.6
And so on. Note that Tomatoes does not know anything about ketchup or olive oil, it just appends $0.2 to the cost of previous pizza state. In 
other words, we're externaling the functionality of our base component (pizza counterpart) with each decorator being attached.

[General UML]
[Specific UML]





