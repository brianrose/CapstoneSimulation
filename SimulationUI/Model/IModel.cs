using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulationEngine;

namespace SimulationUI.Model
{
    public interface IModel
    {
        void Attach(IModelObserver modelObserver);
        void AddSimulation(ISimulation simulation);
    }
}
