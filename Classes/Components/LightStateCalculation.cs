namespace BerlinClock.Classes.Panel
{
    using System;

    using BerlinClock.Classes.Clock.Enums;
    using BerlinClock.Classes.Panel.Interfaces;

    public class LightStateCalculation : ILightStateCalculation
    {
        protected string Time { get; private set; }
        public LightStateCalculation(string time)
        {
            SetNewTime(time);
        }

        public void SetNewTime(string time)
        {
            Time = time;
        }

        public LightState CalculateLightState(byte position)
        {
            var time = TimeSpan.Parse(Time);
            int hours = time.Hours;
            int minutes = time.Minutes;
            int seconds = time.Seconds;
            switch (position)
            {
                case 0:
                    return seconds % 2 == 0 ? LightState.On : LightState.Off;
                case 1:
                    return hours / 5 >= 1 ? LightState.On : LightState.Off;
                case 2:
                    return hours / 5 >= 2 ? LightState.On : LightState.Off;
                case 3:
                    return hours / 5 >= 3 ? LightState.On : LightState.Off;
                case 4:
                    return hours / 5 >= 4 ? LightState.On : LightState.Off;
                case 5:
                    return hours % 5 >= 1 ? LightState.On : LightState.Off;
                case 6:
                    return hours % 5 >= 2 ? LightState.On : LightState.Off;
                case 7:
                    return hours % 5 >= 3 ? LightState.On : LightState.Off;
                case 8:
                    return hours % 5 == 4 ? LightState.On : LightState.Off;
                case 9:
                    return minutes / 5 >= 1 ? LightState.On : LightState.Off;
                case 10:
                    return minutes / 5 >= 2 ? LightState.On : LightState.Off;
                case 11:
                    return minutes / 5 >= 3 ? LightState.On : LightState.Off;
                case 12:
                    return minutes / 5 >= 4 ? LightState.On : LightState.Off;
                case 13:
                    return minutes / 5 >= 5 ? LightState.On : LightState.Off;
                case 14:
                    return minutes / 5 >= 6 ? LightState.On : LightState.Off;
                case 15:
                    return minutes / 5 >= 7 ? LightState.On : LightState.Off;
                case 16:
                    return minutes / 5 >= 8 ? LightState.On : LightState.Off;
                case 17:
                    return minutes / 5 >= 9 ? LightState.On : LightState.Off;
                case 18:
                    return minutes / 5 >= 10 ? LightState.On : LightState.Off;
                case 19:
                    return minutes / 5 >= 11 ? LightState.On : LightState.Off;
                case 20:
                    return minutes % 5 >= 1 ? LightState.On : LightState.Off;
                case 21:
                    return minutes % 5 >= 2 ? LightState.On : LightState.Off;
                case 22:
                    return minutes % 5 >= 3 ? LightState.On : LightState.Off;
                case 23:
                    return minutes % 5 == 4 ? LightState.On : LightState.Off;
                default:
                    return LightState.Off;
            }
        }
    }
}