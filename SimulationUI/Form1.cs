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
using SimulationEngine.Configuration;
using SimulationEngine.Specifications;
using SimulationUI.Controller;
using SimulationUI.Model;
using SimulationUI.View;

namespace SimulationUI
{
    public partial class Form1 : Form, IView, IModelObserver
    {
        private int simulationCount = 0;

        private IFileSystemAgent fileSystemAgent;
        private IPhysicsEquationsProvider physicsEquationsProvider;
        private IConverter converter;
        private IConfiguration configuration;

        private IController controller;
        public event ViewHandler<IView> Changed;

        public Form1(IFileSystemAgent fileSystemAgent, IPhysicsEquationsProvider physicsEquationsProvider,
            IConverter converter, IConfiguration configuration)
        {
            this.fileSystemAgent = fileSystemAgent;
            this.physicsEquationsProvider = physicsEquationsProvider;
            this.converter = converter;
            this.configuration = configuration;
            InitializeComponent();
        }

        public Form1()
        {
            this.fileSystemAgent = new FileSystemAgent();
            this.physicsEquationsProvider = new PhysicsEquationsProvider();
            this.converter = new Converter();
            this.configuration = new Configuration();
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
                ListViewItem row = new ListViewItem(simulation.Id.ToString());
                string specificationsDisplay = simulation.Specifications.Aggregate("", (current, specification) => current + $"{{{specification.Display}}}");
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, specificationsDisplay));
                listView1.Items.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = this.simulationCount;
            this.simulationCount++;
            var ledPosition = new Position(double.Parse(sourceXTextBox.Text), double.Parse(sourceYTextBox.Text),
                double.Parse(sourceZTextBox.Text));
            var detectorPosition = new Position(double.Parse(detectorXTextBox.Text), double.Parse(detectorYTextBox.Text),
                double.Parse(detectorZTextBox.Text));
            var specifications = new ISpecification[]
            {
                new LedSpecification(int.Parse(wavelengthTextBox.Text), int.Parse(powerTextBox.Text), ledPosition, this.configuration.SimulationDirectory(id), this.physicsEquationsProvider, this.fileSystemAgent),
                new DetectorSpecification(int.Parse(radiusTextBox.Text), detectorPosition, this.configuration.SimulationDirectory(id), this.fileSystemAgent),
                new TimeSpecification(converter.ParseTimeSpan(timeTextBox.Text), this.configuration.SimulationDirectory(id), this.fileSystemAgent)
            };
            this.controller.AddSimulation(new Simulation(id, specifications));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in this.listView1.Items)
            {
                var listViewItem = item as ListViewItem;
                if (listViewItem != null)
                {
                    this.controller.RunSimulation(int.Parse(listViewItem.Text));
                }
            }
        }
    }
}
