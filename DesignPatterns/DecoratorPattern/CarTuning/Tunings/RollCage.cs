using CarTuning.Cars;

namespace CarTuning.Tunings
{
    public class RollCage : ITuning
    {
        private readonly ICar _car;

        public RollCage(ICar car)
        {
            _car = car;
        }

        public double Acceleration() => _car.Acceleration() - 0.5;

        public double MaxSpeed() => _car.MaxSpeed();
    }
}
