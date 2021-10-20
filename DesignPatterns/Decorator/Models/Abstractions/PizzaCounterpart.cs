namespace Decorator.Models.Abstractions
{
    public abstract class PizzaCounterpart
    {
        public string Description { get; set; } = "Very tasty, yummmmmmmmmmm";
        public abstract double Cost();
    }
}
