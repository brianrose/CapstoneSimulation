namespace SimulationEngine.Specifications
{
    public interface ISpecification
    {
        string Display { get; }
        void SetInput();
    }
}
