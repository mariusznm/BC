namespace BerlinClock.Classes.Components.Interfaces
{
    /// <summary>
    /// Visualization interface. Display method shows visual representation of a light.
    /// </summary>
    public interface IVisualization
    {
        string Display(ILight light);
    }
}