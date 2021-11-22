using Automotive.Models.LightStrategies;
using Automotive.Models.RechargeStrategies;
using Automotive.Models.RefillStrategies;

namespace Automotive.Models
{
    public class Car
    {
        public ILightStrategy LightStrategy { get; set; }

        public IRefillStrategy RefillStrategy { get; set; }

        public IRechargeStrategy RechargeStrategy { get; set; }
    }
}
