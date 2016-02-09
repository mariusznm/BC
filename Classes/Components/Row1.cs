namespace BerlinClock.Classes.Components
{
    using System;

    using BerlinClock.Classes.Components.Enums;
    using BerlinClock.Classes.Components.Interfaces;

    public class Row1 : Row
    {
        public Row1(TimeSpan timeSpan, int order, bool lastRow, IVisualization visualization) : base(timeSpan, order, lastRow, visualization)
        {
        }

        public override ILight[] PutAllLightsIn()
        {
            var lights = new ILight[1];
            ILight light0 = new Light(Visualization, LightType.RoundY);
            lights[0] = light0;
            return lights;
        }

        public override void CalculateLightsStates()
        {
            int seconds = Time.Seconds;
            Lights[0].SetLightState(seconds % 2 == 0 ? LightState.On : LightState.Off);
        }    
    }
}