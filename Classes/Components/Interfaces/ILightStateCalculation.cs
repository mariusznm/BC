namespace BerlinClock.Classes.Components.Interfaces
{
    using BerlinClock.Classes.Components.Enums;

    /// <summary>
    /// Calculate current state based on the socket position and defined time
    /// </summary>
    public interface ILightStateCalculation
    {
        LightState CalculateLightState(byte position);

        void SetNewTime(string time);
    }
}