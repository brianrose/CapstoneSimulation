namespace SimulationEngine
{
    public interface ISimulation
    {
        int Wavelength
        {
            get;
        }
        bool Simulate();
    }
}
