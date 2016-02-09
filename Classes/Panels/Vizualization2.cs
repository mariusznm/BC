namespace BerlinClock.Classes.Panels
{
    using BerlinClock.Classes.Components.Enums;
    using BerlinClock.Classes.Components.Interfaces;

    /// <summary>
    /// This is not a code repetition. This class is to show another implementation of visualization.
    /// </summary>
    public class Visualization2 : IVisualization
    {
        public string Display(ILight light)
        {
            switch (light.GetLightType())
            {
                    case LightType.BigR:
                    return light.GetLightState() == LightState.On ? "R" : "_";
                    case LightType.BigY:
                    return light.GetLightState() == LightState.On ? "Y" : "_";
                    case LightType.RoundY:
                    return light.GetLightState() == LightState.On ? "O" : "_";
                    case LightType.SmallR:
                    return light.GetLightState() == LightState.On ? "r" : "_";
                    case LightType.SmallY:
                    return light.GetLightState() == LightState.On ? "y" : "_";
                default:
                    return "?";
            }
        }
    }
}