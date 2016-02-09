namespace BerlinClock.Classes.Panels
{
    using System;

    using BerlinClock.Classes.Components.Interfaces;

    public interface IPanel : IDisplay
    {
        void SetTime(TimeSpan time);
    }
}