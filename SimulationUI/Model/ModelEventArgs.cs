using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulationEngine;

namespace SimulationUI.Model
{
    public class ModelEventArgs : EventArgs
    {
        public ICollection<ISimulation> Simulations;

        public ModelEventArgs(ICollection<ISimulation> simulations)
        {
            this.Simulations = simulations;
        }
    }
}
