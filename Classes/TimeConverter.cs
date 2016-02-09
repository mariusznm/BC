namespace BerlinClock.Classes
{
    public class TimeConverter : ITimeConverter
    {
        private readonly Clock.Clock clock = new Clock.Clock();

        public string ConvertTime(string time)
        {
            clock.SetTime(time);
            return clock.Display();
        }
    }
}
