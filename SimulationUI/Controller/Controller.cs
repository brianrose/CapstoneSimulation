using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulationEngine;
using SimulationUI.Model;
using SimulationUI.View;

namespace SimulationUI.Controller
{
    class Controller : IController
    {
        private IView view;
        private IModel model;

        public Controller(IView view, IModel model)
        {
            this.view = view;
            this.model = model;
            view.SetController(this);
            model.Attach((IModelObserver) view);
            view.Changed += new ViewHandler<IView>(this.ViewChanged);
        }

        public void AddSimulation(ISimulation simulation)
        {
            model.AddSimulation(simulation);
        }

        public void RunSimulation(int id)
        {
            this.model.RunSimulation(id);
        }

        public void ViewChanged(IView view, ViewEventArgs e)
        {
            this.model.AddSimulation(e.Simulation);
        }
    }
}
