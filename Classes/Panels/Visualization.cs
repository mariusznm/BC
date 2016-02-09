namespace BerlinClock.Classes.Panels
{
    using BerlinClock.Classes.Components.Enums;
    using BerlinClock.Classes.Components.Interfaces;

    public class Visualization : IVisualization
    {
        public string Display(ILight light)
        {
            switch (light.GetLightType())
            {
                    case LightType.BigR:
                    return light.GetLightState() == LightState.On ? "R" : "O";
                    case LightType.BigY:
                    return light.GetLightState() == LightState.On ? "Y" : "O";
                    case LightType.RoundY:
                    return light.GetLightState() == LightState.On ? "Y" : "O";
                    case LightType.SmallR:
                    return light.GetLightState() == LightState.On ? "R" : "O";
                    case LightType.SmallY:
                    return light.GetLightState() == LightState.On ? "Y" : "O";
                default:
                    return "?";
            }
        }
    }
}