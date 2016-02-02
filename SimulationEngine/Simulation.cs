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

        public int Id { get; }
        public ISpecification[] Specifications { get; }
        public IProcessing[] Processings { get; }

        public void Simulate()
        {
            throw new NotImplementedException();
        }

        public IProcessingResult[] Process()
        {
            throw new NotImplementedException();
        }
    }
}
