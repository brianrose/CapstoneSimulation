using System;
using SimulationEngine.Processing;
using SimulationEngine.Specifications;

namespace SimulationEngine
{
    public class Simulation : ISimulation
    {
        public Simulation(int id, ISpecification[] specifications, params IProcessing[] processing)
        {
            this.Id = id;
            this.Specifications = specifications;
            this.Processings = processing;
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
