namespace SimulationEngine.Specifications
{
    public class Position
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public Position(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return $"x = {this.X} mm, y = {this.Y} mm, z = {this.Z} mm";
        }
    }
}
