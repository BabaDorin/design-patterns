﻿using Decorator.Models.Abstractions;

namespace Decorator.Models.Concretions.PizzaDecorations
{
    public class OliveOil : PizzaDecorator
    {

        PizzaCounterpart _counterpart;

        public OliveOil(PizzaCounterpart counterpart)
        {
            _counterpart = counterpart;
        }

        public override double Cost()
        {
            return _counterpart.Cost() + 0.1;
        }
    }
}
