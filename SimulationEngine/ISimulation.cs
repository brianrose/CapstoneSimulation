using SimulationEngine.Processing;
using SimulationEngine.Specifications;

namespace SimulationEngine
{
    public interface ISimulation
    {
        int Id { get; }
        ISpecification[] Specifications { get; }
        IProcessing[] Processings { get; }
        void Simulate();
        IProcessingResult[] Process();
    }
}
