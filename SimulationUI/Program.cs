using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimulationEngine;
using SimulationEngine.Configuration;
using SimulationUI.Controller;
using SimulationUI.Model;

namespace SimulationUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Form1 view = new Form1(new FileSystemAgent(), new PhysicsEquationsProvider(), new Converter(), new Configuration());
            IModel model = new Model.Model(new FileSystemAgent(), new Configuration());
            IController controller = new Controller.Controller(view, model);
            Application.Run(view);
        }
    }
}
