using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationUI.Model
{
    public interface IModelObserver
    {
        void SimulationsChanged(IModel model, ModelEventArgs e);
    }
}
