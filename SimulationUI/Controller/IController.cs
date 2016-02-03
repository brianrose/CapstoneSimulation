using SimulationEngine;

namespace SimulationUI.Controller
{
    public interface IController
    {
        void AddSimulation(ISimulation simulation);
        void RunSimulation(int id);
    }
}
