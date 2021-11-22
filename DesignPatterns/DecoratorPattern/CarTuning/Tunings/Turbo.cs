using CarTuning.Cars;

namespace CarTuning.Tunings
{
    public class Turbo : ITuning
    {
        private ICar _car;

        public Turbo(ICar car)
        {
            _car = car;
        }

        public double Acceleration() => _car.Acceleration() + 2.4;

        public double MaxSpeed() => _car.MaxSpeed() + 100;
    }
}
