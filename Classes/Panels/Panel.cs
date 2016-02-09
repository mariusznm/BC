namespace BerlinClock.Classes.Panels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using BerlinClock.Classes.Components;
    using BerlinClock.Classes.Components.Interfaces;

    public class Panel : IPanel
    {
        private IList<IRow> Rows { get; set; }

        public Panel(TimeSpan time)
        {
            IVisualization visualization = new Visualization();
            Rows = new List<IRow>
                       {
                           new Row1(time, 0, false, visualization),
                           new Row2(time, 1, false, visualization),
                           new Row3(time, 2, false, visualization),
                           new Row4(time, 3, false, visualization),
                           new Row5(time, 4, true, visualization)
                       };
        }

        public string Display()
        {
            return Rows.OrderBy(r => r.Order).Aggregate(string.Empty, (current, row) => current + row.Display());
        }

        public void SetTime(TimeSpan time)
        {
            foreach (var row in Rows)
            {
                row.SetTime(time);
            }
        }
    }
}
