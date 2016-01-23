using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulationEngine;

namespace SimulationUI.View
{
    public class ViewEventArgs : EventArgs
    {
        public ISimulation Simulation;

        public ViewEventArgs(ISimulation simulation)
        {
            this.Simulation = simulation;
        }
    }
}
