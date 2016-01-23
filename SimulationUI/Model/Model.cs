using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulationEngine;

namespace SimulationUI.Model
{
    class Model : IModel
    {
        public event ModelHandler<Model> Changed; 
        ICollection<ISimulation> simulations;

        public Model()
        {
            this.simulations = new List<ISimulation>();
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
    }
}
