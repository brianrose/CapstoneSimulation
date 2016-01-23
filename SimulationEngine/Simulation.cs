using System;

namespace SimulationEngine
{
    public class Simulation : ISimulation
    {
        private int wavelength;

        public Simulation(int wavelength)
        {
            this.wavelength = wavelength;
        }

        public bool Simulate()
        {
            throw new NotImplementedException();
        }
    }
}
