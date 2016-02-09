namespace BerlinClock.Classes.Components
{
    using System;

    using BerlinClock.Classes.Components.Enums;
    using BerlinClock.Classes.Components.Interfaces;

    public class Row4 : Row
    {
        public Row4(TimeSpan timeSpan, int order, bool lastRow, IVisualization visualization) : base(timeSpan, order, lastRow, visualization)
        {
        }

        public override ILight[] PutAllLightsIn()
        {
            var lights = new ILight[11];
            lights[0] = new Light(Visualization, LightType.SmallY);
            lights[1] = new Light(Visualization, LightType.SmallY);
            lights[2] = new Light(Visualization, LightType.SmallR);
            lights[3] = new Light(Visualization, LightType.SmallY);
            lights[4] = new Light(Visualization, LightType.SmallY);
            lights[5] = new Light(Visualization, LightType.SmallR);
            lights[6] = new Light(Visualization, LightType.SmallY);
            lights[7] = new Light(Visualization, LightType.SmallY);
            lights[8] = new Light(Visualization, LightType.SmallR);
            lights[9] = new Light(Visualization, LightType.SmallY);
            lights[10] = new Light(Visualization, LightType.SmallY);
            
            return lights;
        }

        public override void CalculateLightsStates()
        {
            this.SetActiveLights(55, 5, Time.Minutes);
        }
    }
}
