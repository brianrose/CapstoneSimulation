using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulationEngine;
using SimulationEngine.Configuration;

namespace SimulationUI.Model
{
    class Model : IModel
    {
        public event ModelHandler<Model> Changed; 
        ICollection<ISimulation> simulations;
        private IFileSystemAgent fileSystemAgent;
        private IConfiguration configuration;

        public Model(IFileSystemAgent fileSystemAgent, IConfiguration configuration)
        {
            this.simulations = new List<ISimulation>();
            this.fileSystemAgent = fileSystemAgent;
            this.configuration = configuration;
        }

        public void Attach(IModelObserver modelObserver)
        {
            this.Changed += new ModelHandler<Model>(modelObserver.SimulationsChanged);
        }

        public void AddSimulation(ISimulation simulation)
        {
            this.simulations.Add(simulation);
            this.Changed.Invoke(this, new ModelEventArgs(simulations));
        }

        public void RunSimulation(int id)
        {
            var simulation = this.simulations.First(s => s.Id == id);
            this.fileSystemAgent.CreateSimulationEnvironment(this.configuration.SimulationDirectory(simulation.Id));
            foreach (var specification in simulation.Specifications)
            {
                specification.SetInput();
            }
            this.fileSystemAgent.RunSimulation(this.configuration.SimulationDirectory(simulation.Id));
        }
    }
}
