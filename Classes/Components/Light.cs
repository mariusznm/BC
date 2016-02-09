namespace BerlinClock.Classes.Components
{
    using BerlinClock.Classes.Components.Enums;
    using BerlinClock.Classes.Components.Interfaces;

    public class Light : ILight
    {
        private LightType LightType { get; set; }

        private IVisualization Visualization { get; set; }

        private LightState LightState { get; set; }
        
        public Light(IVisualization visualization, LightType lightType)
        {
            Visualization = visualization;
            LightType = lightType;
        }

        public string Display()
        {
            return Visualization.Display(this);
        }

        public void SetLightState(LightState lightState)
        {
            LightState = lightState;
        }

        public LightType GetLightType()
        {
            return LightType;
        }

        public LightState GetLightState()
        {
            return LightState;
        }
    }
}
