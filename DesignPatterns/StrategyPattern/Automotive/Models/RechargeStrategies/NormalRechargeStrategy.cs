namespace Automotive.Models.RechargeStrategies
{
    public class NormalRechargeStrategy : IRechargeStrategy
    {
        public void Recharge()
        {
            Console.WriteLine("Recharge car battery");
        }
    }
}
