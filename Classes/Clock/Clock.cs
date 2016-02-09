namespace BerlinClock.Classes.Clock
{
    using System;
    using System.Globalization;

    using BerlinClock.Classes.Components.Interfaces;
    using BerlinClock.Classes.Panels;

    public class Clock : IDisplay
    {
        private readonly IPanel panel;

        public Clock() : this("00:00:00")
        {
        }
        
        public Clock(string time)
        {
            var timeSpan = time == "24:00:00" ? TimeSpan.Parse("1.00:00:00") : TimeSpan.ParseExact(time, "c", CultureInfo.InvariantCulture);
            panel = new Panel(timeSpan);
        }

        public void SetTime(string time)
        {
            var timeSpan = time == "24:00:00" ? TimeSpan.Parse("1.00:00:00") : TimeSpan.ParseExact(time, "c", CultureInfo.InvariantCulture);
            panel.SetTime(timeSpan);
        }

        public string Display()
        {
            return panel.Display();   
        }
    }
}
