namespace SimulationEngine.Configuration
{
    public class Configuration : IConfiguration
    {
        public string SimulationDirectory(int id)
        {
            return $"simulations/simulation/{id}";
        }
    }
}
