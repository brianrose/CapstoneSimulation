using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulationUI.Controller;

namespace SimulationUI.View
{
    public interface IView
    {
        event ViewHandler<IView> Changed;
        void SetController(IController controller);
    }
}
