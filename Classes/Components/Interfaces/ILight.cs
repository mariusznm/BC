namespace BerlinClock.Classes.Components.Interfaces
{
    using BerlinClock.Classes.Components.Enums;

    /// <summary>
    /// Light ...
    /// </summary>
    public interface ILight : IDisplay
    {
        LightType GetLightType();

        LightState GetLightState();

        void SetLightState(LightState lightState);
    }
}
