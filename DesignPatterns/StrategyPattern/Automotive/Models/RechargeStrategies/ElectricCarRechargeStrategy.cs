namespace Automotive.Models.RechargeStrategies
{
    public class ElectricCarRechargeStrategy : IRechargeStrategy
    {
        public void Recharge()
        {
            Console.WriteLine("Recharge electric car battery.");
        }
    }
}
