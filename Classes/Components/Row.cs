namespace BerlinClock.Classes.Components
{
    using System;
    using System.Linq;

    using BerlinClock.Classes.Components.Enums;
    using BerlinClock.Classes.Components.Interfaces;

    public abstract class Row : IRow
    {
        public int Order { get; set; }

        public bool LastRow { get; set; }

        protected IVisualization Visualization { get; set; }

        protected ILight[] Lights { get; private set; }
        
        protected TimeSpan Time { get; private set; }

        protected Row(TimeSpan timeSpan, int order, bool lastRow, IVisualization visualization)
        {
            Visualization = visualization;
            Order = order;
            LastRow = lastRow;
            Lights = GenerateLights();
            Time = timeSpan;
        }

        public abstract ILight[] PutAllLightsIn();

        public abstract void CalculateLightsStates();

        public string Display()
        {
            CalculateLightsStates();
            var result = Lights.Aggregate(string.Empty, (current, light) => current + light.Display());
            if (!LastRow)
            {
                result += "\r\n";
            }

            return result;
        }

        public void SetActiveLights(int maxValue, int interval, int value)
        {
            int[] coll = new int[maxValue / interval];
            int v = 0;
            for (var i = 0; i <= coll.Length - 1; i++)
            {
                v += interval;
                coll[i] = v;
            }

            var activeLights = coll.Where(i => i <= value).Count();

            for (int i = 0; i <= activeLights - 1; i++)
            {
                Lights[i].SetLightState(LightState.On);
            }

            for (int i = activeLights; i <= Lights.Length - 1; i++)
            {
                Lights[i].SetLightState(LightState.Off);
            }
        }
        
        public void SetTime(TimeSpan time)
        {
            Time = time;
        }

        private ILight[] GenerateLights()
        {
            return PutAllLightsIn();
        }
    }
}
