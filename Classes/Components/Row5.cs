namespace BerlinClock.Classes.Components
{
    using System;

    using BerlinClock.Classes.Components.Enums;
    using BerlinClock.Classes.Components.Interfaces;

    public class Row5 : Row
    {
        public Row5(TimeSpan timeSpan, int order, bool lastRow, IVisualization visualization) : base(timeSpan, order, lastRow, visualization)
        {
        }

        public override ILight[] PutAllLightsIn()
        {
            var lights = new ILight[4];
            lights[0] = new Light(Visualization, LightType.BigY);
            lights[1] = new Light(Visualization, LightType.BigY);
            lights[2] = new Light(Visualization, LightType.BigY);
            lights[3] = new Light(Visualization, LightType.BigY);
            
            return lights;
        }

        public override void CalculateLightsStates()
        {
            this.SetActiveLights(4, 1, Time.Minutes % 5);
        }
    }
}
