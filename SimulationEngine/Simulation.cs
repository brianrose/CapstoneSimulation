using System;

namespace SimulationEngine
{
    public class Simulation : ISimulation
    {
        public Simulation(int wavelength)
        {
            this.Wavelength = wavelength;
        }

        public int Wavelength
        {
            get;
        }

        public bool Simulate()
        {
            throw new NotImplementedException();
        }
    }
}
