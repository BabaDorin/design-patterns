namespace Automotive.Models.RefillStrategies
{
    public class GasolineRefillStrategy : IRefillStrategy
    {
        public void Refill()
        {
            Console.WriteLine("Gasoline refill");
        }
    }
}
