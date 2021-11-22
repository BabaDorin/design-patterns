using Automotive.Models;
using Automotive.Models.LightStrategies;
using Automotive.Models.RechargeStrategies;
using Automotive.Models.RefillStrategies;

// The client:
// Gimme a diesel car with normal recharging and led lights

// Me:
// Hold my Head First Design Patterns book

var car = new Car
{
    LightStrategy = new LedLightStrategy(),
    RechargeStrategy = new NormalRechargeStrategy(),
    RefillStrategy = new DieselRefillStrategy()
};

car.LightStrategy.Light();
car.RechargeStrategy.Recharge();
car.RefillStrategy.Refill();