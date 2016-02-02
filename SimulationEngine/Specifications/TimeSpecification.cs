using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationEngine.Specifications
{
    class TimeSpecification : ISpecification
    {
        private IFileSystemAgent fileSystemAgent;
        private readonly string file;

        public TimeSpan TimeSpan { get; }
        public string Display => this.TimeSpan.ToString();

        public TimeSpecification(TimeSpan timeSpan, string simulationDirectory, IFileSystemAgent fileSystemAgent)
        {
            this.TimeSpan = timeSpan;
            this.fileSystemAgent = fileSystemAgent;
            this.file = $"{simulationDirectory}/brain.inp";
        }

        public void SetInput()
        {
            this.fileSystemAgent.WriteInput(this.file, 5, 1, "0.0");
            this.fileSystemAgent.WriteInput(this.file, 5, 2, this.TimeSpan.ToString());
        }
    }
}
