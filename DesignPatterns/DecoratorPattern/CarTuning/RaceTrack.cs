using CarTuning.Cars;

namespace CarTuning
{
    public class RaceTrack
    {
        private readonly ICar[] _participants;
        private readonly double[] _distances;

        public RaceTrack(params ICar[] participants)
        {
            _participants = participants;
            _distances = new double[participants.Length];
        }

        /// <summary>
        /// Simulates a 1/4 mile dragrace (400m)
        /// </summary>
        /// <param name="cars"></param>
        public void StartRace()
        {
            int secondsEllapsed = 0;

            while (_distances.Any(d => d < 400))
            {
                for (int i = 0; i < _participants.Length; i++)
                {
                    var dist = _distances[i];

                    if (dist >= 400)
                        continue;

                    var car = _participants[i];
                    var currentVelocity = car.Acceleration() * secondsEllapsed;
                    
                    if(currentVelocity > car.MaxSpeed())
                        currentVelocity = car.MaxSpeed();

                    _distances[i] += currentVelocity;
                    if (_distances[i] > 400)
                        _distances[i] = 400;
                }

                PrintRaceState();
                
                Thread.Sleep(1000);
                ++secondsEllapsed;
            }
        }

        public void PrintRaceState()
        {
            Console.Clear();

            foreach (var dist in _distances)
            {
                Console.WriteLine(new String('-', (int)dist/5) + "O≈o>");
            }
        }
    }
}
