namespace BerlinClock.Classes.Components.Interfaces
{
    using System;

    public interface IRow : IDisplay
    {
        int Order { get; set; }

        ILight[] PutAllLightsIn();

        void CalculateLightsStates();

        void SetTime(TimeSpan time);
    }
}
