﻿namespace BerlinClock.Classes.Components
{
    using System;

    using BerlinClock.Classes.Components.Enums;
    using BerlinClock.Classes.Components.Interfaces;

    public class Row3 : Row
    {
        public Row3(TimeSpan timeSpan, int order, bool lastRow, IVisualization visualization) : base(timeSpan, order, lastRow, visualization)
        {
        }

        public override ILight[] PutAllLightsIn()
        {
            var lights = new ILight[4];
            lights[0] = new Light(Visualization, LightType.BigR);
            lights[1] = new Light(Visualization, LightType.BigR);
            lights[2] = new Light(Visualization, LightType.BigR);
            lights[3] = new Light(Visualization, LightType.BigR);
            return lights;
        }

        public override void CalculateLightsStates()
        {
            this.SetActiveLights(5, 1, (int)Time.TotalHours % 5);
        }
    }
}
