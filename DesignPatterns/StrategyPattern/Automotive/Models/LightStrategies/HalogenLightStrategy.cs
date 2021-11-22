namespace Automotive.Models.LightStrategies
{
    public class HalogenLightStrategy : ILightStrategy
    {
        public void Light()
        {
            Console.WriteLine("Halogen light");
        }
    }
}
