namespace Automotive.Models.RefillStrategies
{
    public class DieselRefillStrategy : IRefillStrategy
    {
        public void Refill()
        {
            Console.WriteLine("Diesel refill");
        }
    }
}
