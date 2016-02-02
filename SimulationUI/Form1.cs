using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimulationEngine;
using SimulationEngine.Specifications;
using SimulationUI.Controller;
using SimulationUI.Model;
using SimulationUI.View;

namespace SimulationUI
{
    public partial class Form1 : Form, IView, IModelObserver
    {
        private IController controller;
        public event ViewHandler<IView> Changed;

        public Form1()
        {
            InitializeComponent();
        }

        public void SetController(IController controller)
        {
            this.controller = controller;
        }

        public void SimulationsChanged(IModel model, ModelEventArgs e)
        {
            this.listView1.Items.Clear();

            foreach (var simulation in e.Simulations)
            {
                this.listView1.Items.Add(new ListViewItem());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var specifications = new List<ISpecification>()
            {
                // TODO: Specifications
            };
        }
    }
}
