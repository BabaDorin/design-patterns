namespace Automotive.Models.LightStrategies
{
    public class LedLightStrategy : ILightStrategy
    {
        public void Light()
        {
            Console.WriteLine("Led light");
        }
    }
}
