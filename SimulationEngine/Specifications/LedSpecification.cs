using System;

namespace SimulationEngine.Specifications
{
    public class LedSpecification : ISpecification
    {
        private IPhysicsEquationsProvider physicsEquationsProvider;
        private IFileSystemAgent fileSystemAgent;
        private readonly string file;

        public int Wavelength { get; }
        public int Power { get; }
        public Position Position { get; }

        public LedSpecification(int wavelength, int power, Position position,
            string simulationDirectory, IPhysicsEquationsProvider physicsEquationsProvider, IFileSystemAgent filesSystemAgent)
        {
            this.Wavelength = wavelength;
            this.Power = power;
            this.Position = position;
            this.physicsEquationsProvider = physicsEquationsProvider;
            this.fileSystemAgent = filesSystemAgent;
            this.file = $"{simulationDirectory}/brain.inp";
        }

        public string Display => $"LED Specification: {this.Wavelength} nm, {this.Power} mW, {this.Position}";

        public void SetInput()
        {
            this.fileSystemAgent.WriteInput(this.file, 5, 3, this.physicsEquationsProvider.WavelengthToTimeStep(this.Wavelength).ToString());

            var photonsPerSecond = this.physicsEquationsProvider.PowerToPhotonsPerSecond(this.Power);
            var startTime = DateTime.Parse(this.fileSystemAgent.ReadInput(this.file, 5, 1));
            var endTime = DateTime.Parse(this.fileSystemAgent.ReadInput(this.file, 5, 2));
            var timeSpan = endTime - startTime;
            this.fileSystemAgent.WriteInput(this.file, 1, 1, (photonsPerSecond * timeSpan.TotalSeconds).ToString());

            this.fileSystemAgent.WriteInput(this.file, 3, 1, this.Position.X.ToString());
            this.fileSystemAgent.WriteInput(this.file, 3, 2, this.Position.Y.ToString());
            this.fileSystemAgent.WriteInput(this.file, 3, 3, this.Position.Z.ToString());
        }
    }
}
