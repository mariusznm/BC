namespace BerlinClock.Classes.Clock
{
    using System;
    using System.Globalization;

    using BerlinClock.Classes.Components.Interfaces;
    using BerlinClock.Classes.Panels;

    /// This is not a code repetition. This class is to show another implementation of Clock  - with different panel and visualization.
    public class Clock2 : IDisplay
    {
        private readonly IPanel panel;

        public Clock2() : this("00:00:00")
        {
        }
        
        public Clock2(string time)
        {
            var timeSpan = time == "24:00:00" ? TimeSpan.Parse("1.00:00:00") : TimeSpan.ParseExact(time, "c", CultureInfo.InvariantCulture);
            panel = new Panel2(timeSpan);
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
