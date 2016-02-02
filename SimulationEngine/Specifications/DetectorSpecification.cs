namespace SimulationEngine.Specifications
{
    class DetectorSpecification : ISpecification
    {
        private IFileSystemAgent fileSystemAgent;
        private string file;

        public string Display { get; }
        public int Radius { get; }
        public Position Position { get; }

        public DetectorSpecification(int radius, Position position, string simulationDirectory, IFileSystemAgent fileSystemAgent)
        {
            this.Radius = radius;
            this.Position = position;
            this.fileSystemAgent = fileSystemAgent;
            this.file = $"{simulationDirectory}/brain.inp";
        }

        public void SetInput()
        {
            this.fileSystemAgent.WriteInput(this.file, 8, 2, this.Radius.ToString());
            this.fileSystemAgent.WriteInput(this.file, 9, 4, this.Radius.ToString());

            this.fileSystemAgent.WriteInput(this.file, 9, 1, this.Position.X.ToString());
            this.fileSystemAgent.WriteInput(this.file, 9, 2, this.Position.Y.ToString());
            this.fileSystemAgent.WriteInput(this.file, 9, 3, this.Position.Z.ToString());
        }
    }
}
