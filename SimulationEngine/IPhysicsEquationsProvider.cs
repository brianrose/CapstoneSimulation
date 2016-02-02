namespace SimulationEngine
{
    public interface IPhysicsEquationsProvider
    {
        int WavelengthToTimeStep(int wavelength);
        int PowerToPhotonsPerSecond(int power);
    }
}
